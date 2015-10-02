using System;
using System.Windows;
public class Student {
    private int matriculationNumber;
    private string firstName;
    private string secondName;
    private string dateOfBirth;
    private string course;
    private int level = 1;
    private int credits;

    public int MatriculationNumber {
        get {
            return matriculationNumber;
        }
        set {
            matriculationNumber = value;
        }
    }

    public string FirstName {
        get {
            return firstName;
        }
        set {
            firstName = value;
        }
    }

    public string SecondName {
        get {
            return secondName;
        }
        set {
            secondName = value;
        }
    }

    public string DateOfBirth {
        get {
            return dateOfBirth;
        }
        set {
            dateOfBirth = value;
        }
    }

    public string Course {
        get {
            return course;
        }
        set {
            course = value;
        }
    }

    public int Level {
        get {
            return level;
        }
        set {
            if (value > 4) {
                MessageBoxResult error = MessageBox.Show("Student is already in 4th year.");
                throw new ArgumentException("Too large!");
            }

            if ((value == 2 && credits < 120) || (value == 3 && credits < 240) || (value == 4 && credits < 360)) {
                MessageBoxResult error = MessageBox.Show("Not enough credits.");
                throw new ArgumentException("Too Large!");
            }
            level = value;
        }
    }

    public int Credits {
        get {
            return credits;
        }
        set {
            credits = value;
        }
    }

    public void advance() {
        try {
            Level += 1;
        }
        catch (Exception exception) {
            Console.WriteLine(exception);
        }
    }

    public void award() {

    }
}