using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.Entity;

namespace lab_122_wpf_entity_framework
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Student> studentsList = new List<Student>();
        
        Student student;

        public MainWindow()
        {
            InitializeComponent();
            Initialize();
        }

        void Initialize()
        {
            using (var db = new CollegeContext())
            {
                var students01 = new Student
                {
                    StudentName = "Maiwand Hussain",
                    DateOfBirth = new DateTime(1995, 01, 01),
                    Height = 192,
                    Weight = 89
                };

                var students02 = new Student
                {
                    StudentName = "Michael Antonio",
                    DateOfBirth = new DateTime(1997, 01, 01),
                    Height = 248,
                    Weight = 50
                };

                //db.Students.Add(students01);
                //db.Students.Add(students02);
                //db.SaveChanges();

                studentsList = db.Students.ToList<Student>();
                Listbox01.ItemsSource = studentsList;
                Listbox01.DisplayMemberPath = "StudentName";
            }
        }

        private void Listbox01_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            student = (Student)Listbox01.SelectedItem;
            Textbox01.Text = ($"StudentID : {student.StudentID}, \nDOB : {student.DateOfBirth} \nHeight : {student.Height}, \nWeight : {student.Weight}");          
        }
    }

    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public byte[] Photo { get; set; }
        public decimal Height { get; set; }
        public float Weight { get; set; }

        public Qualification Qualification { get; set; }
    }

    public class Qualification
    {
        public int QualificationId { get; set; }
        public string QualificationName { get; set; }
        public string Section { get; set; }

        public ICollection<Student> Students { get; set; }
    }

    public class CollegeContext : DbContext
    {
        // Constructor method : bounce responsibility 
        // back up to Entity DbContext to do all the hard work
        public CollegeContext() : base() { }


        public DbSet<Student> Students { get; set; }
        public DbSet<Qualification> Qualifications { get; set; }
    }
}
