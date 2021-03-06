﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mATHASSIGNMENT
{
    public partial class Form3 : Form
    {
        static int index = 0;
        static string answer = "";
        public int correct = 0;
        public struct Question { public string question; }
        public struct Option { public string option1, option2, option3, option4; }
        public Form3()
        {
            InitializeComponent();
            GenerateQuestionsOptions(index);
            btnNext.Click += new EventHandler(btnNext_Click);
            btnPrevious.Click += new EventHandler(btnPrevious_Click);
            btnSate();
        }
        void btnSate()
        {
            //new inclusion
            if (index == 0) { btnPrevious.Visible = false; }
            else { btnPrevious.Visible = true; }
            int currentNo = index + 1;
            if (currentNo < PopulateQuestions().Rows.Count) { btnNext.Visible = true; }
            if (currentNo == PopulateQuestions().Rows.Count) { MessageBox.Show("This Question has Finished"); btnNext.Visible = false; }
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            usersName.Text = Form1.passingUsername;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            foreach (Control control in groupBox1.Controls)
            {
                if (control.GetType().Name.ToLower() == "radiobutton")
                {
                    if ((control as RadioButton).Checked)
                    {
                        if (answer.ToLower() == (control as RadioButton).Text.ToLower())
                        {
                            correct++;
                        }
                    }
                }
            }
            if (index < PopulateQuestions().Rows.Count - 1)
            {
                index++;
                GenerateQuestionsOptions(index);
                lblAnswer.Visible = false;
            }
            else
            {
                groupBox1.Visible = false;
                btnNext.Visible = false;
                lblAnswer.Visible = true;
                lblAnswer.Text = correct + "  correct answer out of " + PopulateQuestions();
            }
     

        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (index > 0)
            {
                index--;
                GenerateQuestionsOptions(index);
                btnSate();
            }
        }

        public void GenerateQuestionsOptions(int index)
        {
            // Question based on Index
            Question question = new Question();
            question.question = PopulateQuestions().Rows[index]["QuestionDescription"].ToString();

            // Options based on Question
            Option options = new Option();
            options.option1 = PopulateQuestions().Rows[index][1].ToString();
            options.option2 = PopulateQuestions().Rows[index][2].ToString();
            options.option3 = PopulateQuestions().Rows[index][3].ToString();
            options.option4 = PopulateQuestions().Rows[index][4].ToString();

            // Adding options to List for shuffling options
            List<string> optionsList = new List<string>();
            optionsList.Add(options.option1);
            optionsList.Add(options.option2);
            optionsList.Add(options.option3);
            optionsList.Add(options.option4);

            // Shuffle options List
            List<string> shuffledOptions = optionsList.OrderBy(a => Guid.NewGuid()).ToList();

            // Assigning question and options
            lblQuestion.Text = (index + 1) + " " + question.question.ToUpper();
            rbOption1.Text = shuffledOptions[0];
            rbOption2.Text = shuffledOptions[1];
            rbOption5.Text = shuffledOptions[2];
            rbOption4.Text = shuffledOptions[3];
        }

        public List<string> RandomizeList(List<string> originalList)
        {
            List<String> randomList = new List<string>();
            Random random = new Random();
            string value = default(string);
            while (originalList.Count() > 0)
            {
                var nextIndex = random.Next(0, originalList.Count());
                value = originalList[nextIndex];
                randomList.Add(value);
                originalList.RemoveAt(nextIndex);
            }
            return randomList;
                    }

        // Get question and options from database
        private DataTable PopulateQuestions()
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\miran\source\repos\mATHASSIGNMENT\mATHASSIGNMENT\1.1.mdf;Integrated Security=True;Connect Timeout=30");


            SqlCommand comm = new SqlCommand("SELECT * FROM tbl_questions", conn);
            SqlDataAdapter reader = new SqlDataAdapter(comm);
            conn.Open();
            reader.Fill(dt);

            return dt;
        }
        //Get answer for question from database
        private string PopulateCorrectAnswer(string questionDescription)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\miran\source\repos\mATHASSIGNMENT\mATHASSIGNMENT\1.1.mdf; Integrated Security = True; Connect Timeout = 30");


            SqlCommand cap = new SqlCommand("GetCorrectAnswer", conn);
                {
                    cap.CommandType = CommandType.StoredProcedure;
                    cap.Parameters.AddWithValue("@Question", questionDescription);
                    using (SqlDataAdapter da = new SqlDataAdapter(cap))
                    {
                        conn.Open();
                        da.Fill(dt);
                        conn.Close();
                    }
            }
            return dt.Rows[0].ItemArray[0].ToString();
        }
    }
}


