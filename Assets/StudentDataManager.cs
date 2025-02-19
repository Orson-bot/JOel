using UnityEngine;
using UnityEngine.UI;
public class StudentDataManager : MonoBehaviour
{
        public InputField NameInput;
        public InputField AgeIput;
        public InputField studentNumberInput;
        public InputField studentSection;

        public InputField  SearchInput;
    public Text resultText;

  public void SavedStudentData()
    {
        string studentName = NameInput.text;
        int age, studentNumber;
        string Section = studentSection.text;

        if (!string.IsNullOrEmpty(studentName) &&
        int.TryParse(AgeIput.text, out age) &&
        int.TryParse(studentNumberInput.text, out studentNumber) &&
        !string.IsNullOrEmpty(Section)) 
        {
            PlayerPrefs.SetInt(studentName + "Age", age);
            PlayerPrefs.SetInt(studentName + "Student Number", studentNumber);
            PlayerPrefs.SetString(studentName + "Student Section", Section);
            PlayerPrefs.Save();
            Debug.Log("Student Data Saved" + studentName);
        }
        else
        {
            Debug.Log("InvalidInput");
        }

    }
    public void LoadStudentData()
    {
        string studentName = SearchInput.text;
        if (PlayerPrefs.HasKey(studentName + "Age"))
        {

            int age = PlayerPrefs.GetInt(studentName + "Age");
            int studentNumber = PlayerPrefs.GetInt(studentName + "studentNumber");
            string Section = PlayerPrefs.GetString(studentName + "student Section");
            resultText.text = $"Name: {studentName}\nAge:{studentNumberInput}\nSection: {Section}m";

        }
        else
        {
            resultText.text = "Student not found";
        }


    }
        

}
