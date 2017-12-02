using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace DominikSlawkowskiLab4___zad_dom
{
    public partial class FormPdfGenerator : Form
    {
    DataClassesDocumentsDataContext context = new DataClassesDocumentsDataContext();
        public FormPdfGenerator()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Metoda pokazujaca tabele z uczniami w dataGridView
        /// </summary>
         private void Show()
        {
            var students = from student in context.Uczniowies select new { ID = student.ID, Name = student.Imię, Surname = student.Nazwisko, Class = student.Klasa };
            dataGridViewTableLeft.DataSource = students;
        }
        /// <summary>
        /// Wywolanie metody Show przez przycisk
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonShow_Click(object sender, EventArgs e)
        {
            Show();
        }
        /// <summary>
        /// Przycisk wywoluje metode dodajaca ucznia do bazy danych i odswiezajaca dataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text == "" || textBoxSurname.Text == "" || textBoxClass.Text == "") MessageBox.Show("Prosze podac wszystkie dane ucznia");
            else
            {
                Uczniowie student = new Uczniowie();
                student.Imię = textBoxName.Text;
                student.Nazwisko = textBoxSurname.Text;
                student.Klasa = textBoxClass.Text;

                context.Uczniowies.InsertOnSubmit(student);
                context.SubmitChanges(); //TUTAJ KONIECZNA LINIJKA
                Show();
            }
        }
        /// <summary>
        /// Metoda wywolana przez przycisk usuawa ucznia o zadanym ID z bazy danych i ja odswieza
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (comboBoxID.Text == "") MessageBox.Show("Prosze podac ID ucznia");
            else
            {
                Uczniowie student = (from element in context.Uczniowies
                                     where element.ID == Int32.Parse(comboBoxID.Text)
                                     select element).FirstOrDefault(); //LastOrDefault() wtedy usuwa od konca

                context.Uczniowies.DeleteOnSubmit(student);
                context.SubmitChanges();

                Show();
            }
        }
        /// <summary>
        /// Metoda wywolana przez przycisk aktualizuje ucznia o zadanym ID w bazie danych i ja odswieza
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonChange_Click(object sender, EventArgs e)
        {
            if (comboBoxID.Text == "") MessageBox.Show("Prosze podac ID ucznia");
            else
            {
                Uczniowie student = (from element in context.Uczniowies
                                     where element.ID == Int32.Parse(comboBoxID.Text)
                                     select element).FirstOrDefault(); //LastOrDefault() wtedy usuwa od konca

                student.Imię = textBoxName.Text;
                student.Nazwisko = textBoxSurname.Text;
                student.Klasa = textBoxClass.Text;


                context.SubmitChanges();

                Show();
            }
        }
        /// <summary>
        /// W zaleznosci od podanego ID wybierana jest metoda wywolujaca z bazy danych oceny odpowiedniego ucznia
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonShowGrades_Click(object sender, EventArgs e)
        {

            if (comboBoxID.Text == "1")
            {
                var grades = from grade in context.Oceny_ucznia_1s select new { Math = grade.Matematyka, English = grade.Język_polski, NatureScience = grade.Przyroda };
                dataGridViewTableRight.DataSource = grades;
            }

            if (comboBoxID.Text == "2")
            {
                var grades = from grade in context.Oceny_ucznia_2s select new { Math = grade.Matematyka, English = grade.Język_polski, NatureScience = grade.Przyroda };
                dataGridViewTableRight.DataSource = grades;
            }

            if (comboBoxID.Text == "3")
            {
                var grades = from grade in context.Oceny_ucznia_3s select new { Math = grade.Matematyka, English = grade.Język_polski, NatureScience = grade.Przyroda };
                dataGridViewTableRight.DataSource = grades;
            }

            if (comboBoxID.Text == "") MessageBox.Show("Prosze podac ID ucznia");

        }
        /// <summary>
        /// Metoda wyswietlajaca wszystkie uwagi uczniow w dataGridView
        /// </summary>
        private void ShowNotes()
        {
            var notes = from note in context.Uwagi_ucznióws select new { ID = note.ID, Note = note.Uwagi};
            dataGridViewTableBottom.DataSource = notes;
        }
        /// <summary>
        /// Wywolanie metody wyswietlajacej notatki
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonShowNote_Click(object sender, EventArgs e)
        {
            ShowNotes();
        }
        /// <summary>
        /// Metoda dodajaca uwage uczniowi o zadanym ID
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddNote_Click(object sender, EventArgs e)
        {
            if (comboBoxIDToNote.Text == "") MessageBox.Show("Prosze podac ID ucznia");
            else
            {
                Uwagi_uczniów note = (from element in context.Uwagi_ucznióws
                                     where element.ID == Int32.Parse(comboBoxIDToNote.Text)
                                     select element).FirstOrDefault(); //LastOrDefault() wtedy usuwa od konca

                note.Uwagi = textBoxNote.Text;
                context.SubmitChanges();

                ShowNotes();
            }
        }
        /// <summary>
        /// Metoda sprawdza czy wszystkie potrzebne dane zostaly wpisane i wyvbrane, po czym w zaleznosci o wyboru eksportuje dane ucznia do pliku PDF lub csv.
        /// Zostala tu zastosowana biblioteka iText do obslugi plikow PDF
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonExport_Click(object sender, EventArgs e)
        {
            //Pobranie potrzebnych danych z bazy
            var notes = from note in context.Uwagi_ucznióws where note.ID == Int32.Parse(comboBoxIDToNote.Text) select new { note.Uwagi };
            var students = from student in context.Uczniowies where student.ID == Int32.Parse(comboBoxIDToNote.Text) select new { student.ID, student.Imię, student.Nazwisko, student.Klasa };

            if (comboBoxIDToNote.Text == "" || textBoxExport.Text == "" || comboBoxExport.Text == "") MessageBox.Show("Prosze podac ID ucznia / lokalizacje do zapisu pliku / format pliku");
            else
            {
                if(comboBoxExport.Text == "PDF")
                {
                    FileStream fileStream = new FileStream(textBoxExport.Text, FileMode.Create, FileAccess.Write, FileShare.None);
                    iTextSharp.text.Document document = new iTextSharp.text.Document(PageSize.A4);
                    PdfWriter writer = PdfWriter.GetInstance(document, fileStream);
                    document.Open();

                    //Użycie dodatkowych zmiennych var, w celu wydobycia danych
                    foreach (var dataStudent in students)
                    {
                        foreach (var dataNote in notes)
                        {
                            document.Add(new Paragraph(
                                "Uczen #" + dataStudent.ID + "\n"
                               + "   Imie: " + dataStudent.Imię + "\n"
                               + "   Nazwisko: " + dataStudent.Nazwisko + "\n"
                               + "   Klasa: " + dataStudent.Klasa + "\n"
                               + "\n"
                               + "   Tresc uwagi: \n\n"
                               + "   " + dataNote.Uwagi
                                ));
                        }
                    }
                    document.Close();
                    MessageBox.Show("Dokument został pomyślnie wyeksportowany");
                }
                else if(comboBoxExport.Text == "csv")
                {
                    foreach (var dataStudent in students)
                    {
                        foreach (var dataNote in notes)
                        {
                            string[] text = { dataStudent.ID + ";" + dataStudent.Nazwisko + ";" + dataStudent.Imię + ";" + dataStudent.Klasa + ";" + dataNote.Uwagi };
                            System.IO.File.WriteAllLines(textBoxExport.Text, text);
                        }
                    }
                    MessageBox.Show("Dokument został pomyślnie wyeksportowany");
                }
            } 
        }
    }
}
