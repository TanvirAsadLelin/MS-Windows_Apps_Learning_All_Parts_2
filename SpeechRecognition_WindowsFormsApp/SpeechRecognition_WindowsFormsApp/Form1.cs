using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Speech.Synthesis;
using System.Speech.Recognition;

namespace SpeechRecognition_WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTtoS_Click(object sender, EventArgs e)
        {
            if (textBoxTtoS.Text != null)
            {
                SpeechSynthesizer speechSynthesizer = new SpeechSynthesizer();
                speechSynthesizer.Volume = trackBar.Value;
                speechSynthesizer.Speak(textBoxTtoS.Text);
            }
            else
            {
                MessageBox.Show("Please write something!");
            }
        }

        private void btnStoT_Click(object sender, EventArgs e)
        {
            SpeechRecognitionEngine speechRecognitionEngine = new SpeechRecognitionEngine();
            Grammar grammar = new DictationGrammar();

            speechRecognitionEngine.LoadGrammar(grammar);

            try
            {
                textBoxStoT.Text = "Listening now....";

                speechRecognitionEngine.SetInputToDefaultAudioDevice();
                RecognitionResult recognitionResult = speechRecognitionEngine.Recognize();
                textBoxStoT.Clear();
                textBoxStoT.Text = recognitionResult.Text;

            }
            catch
            {
                textBoxTtoS.Text = "";
                MessageBox.Show("No comment found!");
            }

            finally
            {
                speechRecognitionEngine.UnloadAllGrammars();
            }
        }
    }
}
