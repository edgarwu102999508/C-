using System;
using System.Collections.Generic;

namespace Classes_Submittable_Task {
    public class Person {
        public string Firstname;
        public string Surname;
        public string Dob;
        public int Height;

        public class Subject {
            public string SubName;
            public string YearOfDelivery;
            private string newSubject;

            public Subject (string newSubject) {
                this.newSubject = newSubject;
            }
        }

        public List<Subject> Subjects;

        public int RandId () {
            Random rand = new Random ();
            int Id = rand.Next (1000, 9000);
            return Id;
        }

        public Person (string Firstname, string Surname, string Dob, int Height, List<Subject> subjects) {
            this.Firstname = Firstname;
            this.Surname = Surname;
            this.Dob = Dob;
            this.Height = Height;
        }
        public string GetFullName () {
            return this.Firstname + " " + this.Surname;
        }

        public int GetHeightDifference (Person Other) {
            return Math.Abs (this.Height - Other.Height);
        }

        public void AddNewSubject (string newSubject) {
            Subject sub = new Subject (newSubject);
            this.Subjects.Add (sub);
        }
    }
}