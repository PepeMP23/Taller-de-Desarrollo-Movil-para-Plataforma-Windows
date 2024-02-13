using System;
using System.Windows.Input;
using PropertyChanged;
using TDMPW_3P_EX_76724.MVVM.Models;

namespace TDMPW_3P_EX_76724.MVVM.ViewModels
{

    [AddINotifyPropertyChangedInterface]
    public class MainViewModel
    {
        public Subject Subject { get; set; }
        public string NombreMateria { get; set; }
        public double FinalGrade { get; set; }
        public ICommand ClickResult => new Command(() => FinalGrade =
        (Subject.FirstPercentage * Subject.FirstGrade * 0.01) +
        (Subject.SecondPercentage * Subject.SecondGrade * 0.01) +
        (Subject.ThirdPercentage * Subject.ThirdGrade * 0.01)
        );

        public Semester Semester { get; set; }
        public string NameSemesterSubject { get; set; }
        public double FinalGradeForSix { get; set; }
        public double FinalGradeForTen { get; set; }
        public string Announcement { get; set; }
        public ICommand ClickSemesterResult => new Command(() => {
            FinalGradeForSix = (((6 -
            ((Semester.FirstPartialPercentage * Semester.FirstPartialGrade * 0.01) +
            (Semester.SecondPartialPercentage * Semester.SecondPartialGrade * 0.01)))
             * 100) / Semester.ThirdPartialGrade);
            FinalGradeForTen = (((10 -
            ((Semester.FirstPartialPercentage * Semester.FirstPartialGrade * 0.01) +
            (Semester.SecondPartialPercentage * Semester.SecondPartialGrade * 0.01)))
             * 100) / Semester.ThirdPartialGrade);

            if (FinalGradeForSix < 10)
            {
                Announcement = "Se viene remontada. Esto es boca locoo!!!";
            }
            else
            {
                Announcement = "No hay nada que podamos hacer";
            }
        });
        
        public MainViewModel()
		{
            Subject = new Subject
            {
                Name = "",
                FirstCategory = "",
                SecondCategory = "",
                ThirdCategory = "",
                FirstPercentage = 0,
                SecondPercentage = 0,
                ThirdPercentage = 0,
                FirstGrade = 0,
                SecondGrade = 0,
                ThirdGrade = 0
            };

            Semester = new Semester
            {
                SubjectName = "",
                FirstPartialGrade = 0,
                SecondPartialGrade = 0,
                ThirdPartialGrade = 0,
                FirstPartialPercentage = 0,
                SecondPartialPercentage = 0,
                ThirdPartialPercentage = 0
            };
        }
	}
}

