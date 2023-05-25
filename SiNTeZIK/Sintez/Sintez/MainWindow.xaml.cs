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
using System;
using System.Speech.Recognition;
using System.Windows;

namespace WpfTutorialSamples.Audio_and_Video
{
    public partial class SpeechRecognitionTextSample : Window
    {
        public SpeechRecognitionTextSample()
        {
            InitializeComponent();
            SpeechRecognizer speechRecognizer = new SpeechRecognizer();
        }
    }
}
        /*
                private void Speech_Click(object sender, RoutedEventArgs e)
                {
                    PromptBuilder builder = new PromptBuilder();
                    builder.AppendText(t1.Text);
                    SpeechSynthesizer speechSynthesizer = new SpeechSynthesizer();
                    speechSynthesizer.Speak("             ");
                    speechSynthesizer.Speak(builder);
                }*/
    
