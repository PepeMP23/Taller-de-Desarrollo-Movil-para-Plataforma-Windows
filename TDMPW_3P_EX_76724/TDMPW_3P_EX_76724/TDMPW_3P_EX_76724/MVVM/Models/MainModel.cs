using System;
using PropertyChanged;

namespace TDMPW_3P_EX_76724.MVVM.Models
{
	public class MainModel
	{
		public MainModel()
		{
		}
	}

    [AddINotifyPropertyChangedInterface]
    public class Subject
    {
        public string Name { get; set; }
        public string FirstCategory { get; set; }
        public string SecondCategory { get; set; }
        public string ThirdCategory { get; set; }
        public int FirstPercentage { get; set; }
        public int SecondPercentage { get; set; }
        public int ThirdPercentage { get; set; }
        public int FirstGrade { get; set; }
        public int SecondGrade { get; set; }
        public int ThirdGrade { get; set; }

        public Subject()
        {
        }
    }

    [AddINotifyPropertyChangedInterface]
    public class Semester
    {
        public string SubjectName { get; set; }
        public int FirstPartialPercentage { get; set; }
        public int SecondPartialPercentage { get; set; }
        public int ThirdPartialPercentage { get; set; }
        public double FirstPartialGrade { get; set; }
        public double SecondPartialGrade { get; set; }
        public double ThirdPartialGrade { get; set; }

        public Semester()
        {
        }
    }
}

