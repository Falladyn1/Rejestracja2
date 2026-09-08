using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Rejestracja2
{
    public partial class UcNewPatient : UserControl
    {
        public UcNewPatient()
        {
            InitializeComponent();
            LoadDoctors();


            // blokada aby użytkownik najpierw wybrał datę
            cmbDoctor.Enabled = false;
            cmbTime.Enabled = false;
        }

        private void UcCalendar1_DateSelected(object sender, string selectedDate)
        {
            // odebranie zdarzenia wywołanego przez kalendarz i oblokowanie cmb update godzin
            lblSelectedDate.Text = "Wybrana data: " + selectedDate;
            cmbDoctor.Enabled = true;
            cmbTime.Enabled = true;
            UpdateAvailableTimes();
        }

        private void CmbDoctor_SelectedIndexChanged(object? sender, EventArgs e)
        {
            // zmiana lekarza od nowa sprawdzamy godziny
            UpdateAvailableTimes();
        }

        private void LoadDoctors()
        {
            cmbDoctor.Items.Clear();
            cmbDoctor.Items.Add("dr Jan Kowalski");
            cmbDoctor.Items.Add("dr Anna Nowak");
            cmbDoctor.Items.Add("dr Piotr Wiśniewski");
        }

        private void UpdateAvailableTimes()
        {
            cmbTime.Items.Clear();

            // zabezpieczenie przed brakiem lekarza/daty
            if (string.IsNullOrEmpty(ucCalendar1.SelectedDate) || ucCalendar1.SelectedDate == "brak" || cmbDoctor.SelectedItem == null)
            {
                return;
            }

            string selectedDate = ucCalendar1.SelectedDate;
            string selectedDoctor = cmbDoctor.SelectedItem.ToString();


            // lista godzin które są już zajęte
            List<string> bookedTimes = new List<string>();

            // wyciągamy z pliku tylko dla wybranego lekarza i dnia
            foreach (Appointment a in AppointmentDatabase.LoadAppointments())
            {
                if (a.AppDate == selectedDate && a.Doctor == selectedDoctor)
                {
                    bookedTimes.Add(a.AppTime);
                }
            }

            // ustawnie zakresu 8-16 co 30min
            TimeSpan czasStart = new TimeSpan(8, 0, 0);
            TimeSpan czasKoniec = new TimeSpan(16, 0, 0);
            TimeSpan czasWizyty = new TimeSpan(0, 30, 0);

            // petla generująca terminy jesli termin nie jest w bookedTimes to dodajemy do listy
            while (czasStart <= czasKoniec)
            {
                string currentTimeStr = czasStart.ToString(@"hh\:mm");
                if (!bookedTimes.Contains(currentTimeStr))
                {
                    cmbTime.Items.Add(currentTimeStr);
                }
                czasStart = czasStart.Add(czasWizyty);
            }

            cmbTime.SelectedIndex = -1;
            cmbTime.Text = "";
        }

        private void btnFastBooking_Click(object sender, EventArgs e)
        {
            // obsługa kliknięcia przycisku szybkiego zapisu
            // wyszukuje najbliższy wolny termin i automatycznie uzupełnia odpowiednie kontrolki
            var (date, doctor, time) = FindNextAvailableSlot();

            if (date != null && doctor != null && time != null)
            {
                cmbDoctor.Enabled = true;
                cmbTime.Enabled = true;
                cmbDoctor.SelectedItem = doctor;
                ucCalendar1.SelectedDate = date;
                lblSelectedDate.Text = "Wybrana data: " + date;
                UpdateAvailableTimes();
                cmbTime.SelectedItem = time;

                MessageBox.Show($"Znaleziono najbliższy wolny termin!\nData: {date}\nLekarz: {doctor}\nGodzina: {time}",
                    "Szybki zapis", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Brak wolnych terminów w najbliższym czasie!", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private (string date, string doctor, string time) FindNextAvailableSlot()
        {
            // przeszukuje bazę wizyt w poszukiwaniu pierwszego wolnego slotu czasowego 
            
            var appointments = AppointmentDatabase.LoadAppointments();
            string[] doctors = { "dr Jan Kowalski", "dr Anna Nowak", "dr Piotr Wiśniewski" };

            DateTime checkDate = DateTime.Today;

            for (int dayOffset = 0; dayOffset < 30; dayOffset++)
            {
                if (checkDate.DayOfWeek == DayOfWeek.Saturday || checkDate.DayOfWeek == DayOfWeek.Sunday)
                {
                    checkDate = checkDate.AddDays(1);
                    continue;
                }

                string dateStr = checkDate.ToString("dd.MM.yyyy");

                foreach (string doctor in doctors)
                {
                    TimeSpan slotTime = new TimeSpan(8, 0, 0);
                    TimeSpan endTime = new TimeSpan(16, 0, 0);

                    while (slotTime < endTime)
                    {
                        string timeStr = slotTime.ToString(@"hh\:mm");
                        bool isTaken = appointments.Any(a => a.AppDate == dateStr && a.Doctor == doctor && a.AppTime == timeStr);

                        if (!isTaken)
                        {
                            return (dateStr, doctor, timeStr);
                        }

                        slotTime = slotTime.Add(TimeSpan.FromMinutes(30));
                    }
                }
                checkDate = checkDate.AddDays(1);
            }

            return (null, null, null);
        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            // zabezpieczenie pustymi polami
            if (string.IsNullOrWhiteSpace(txtFirstName.Text) || string.IsNullOrWhiteSpace(txtLastName.Text) || string.IsNullOrWhiteSpace(txtPesel.Text))
            {
                MessageBox.Show("Imię, nazwisko i PESEL są wymagane!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // zabezpieczenie przed brakiem daty/lekarza/godziny
            if (string.IsNullOrEmpty(ucCalendar1.SelectedDate) || cmbDoctor.SelectedItem == null || cmbTime.SelectedItem == null)
            {
                MessageBox.Show("Wybierz datę w kalendarzu, lekarza oraz godzinę wizyty!", "Brak danych wizyty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // zabezpieczenie przed odpowiednią długością peselu
            if (txtPesel.Text.Length != 11 || !txtPesel.Text.All(char.IsDigit))
            {
                MessageBox.Show("Numer PESEL musi składać się dokładnie z 11 cyfr!", "Błąd danych", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string pesel = txtPesel.Text;
            List<Patient> patientsList = PatientDatabase.LoadPatients();

            // sprawdzenie czy pacjent już istnieje
            bool patientExists = false;
            foreach (Patient p in patientsList)
            {
                if (p.Pesel == pesel) patientExists = true;
            }

            // zapisanie do pliki jesli nie isteniej
            if (!patientExists)
            {
                Patient newPatient = new Patient(txtFirstName.Text, txtLastName.Text, pesel, txtPhone.Text, txtCity.Text, txtPostCode.Text, txtStreet.Text, txtHomeNum.Text);
                patientsList.Add(newPatient);
                PatientDatabase.SavePatients(patientsList);
            }

            // dodanie nowej wizyty (połączenie przez pesel)
            List<Appointment> appList = AppointmentDatabase.LoadAppointments();
            Appointment newApp = new Appointment(pesel, cmbDoctor.SelectedItem.ToString(), ucCalendar1.SelectedDate, cmbTime.SelectedItem.ToString());
            appList.Add(newApp);
            AppointmentDatabase.SaveAppointments(appList);

            MessageBox.Show("Zarejestrowano pomyślnie!", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // powrot na dashboard
            Panel parentPanel = (Panel)this.Parent;
            if (parentPanel != null)
            {
                parentPanel.Controls.Clear();
                UcDashboard dashboard = new UcDashboard();
                dashboard.Dock = DockStyle.Fill;
                parentPanel.Controls.Add(dashboard);
            }
        }
    }
}