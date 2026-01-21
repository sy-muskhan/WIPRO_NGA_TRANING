using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Speech.Synthesis;

namespace DAY_10._1
{
    public class TextToSpeechConverter
    {
        static void Main(string[] args)
        {
            //Step 1: Add reference to System.Speech assembly
            //Step 2: Import System.Speech.Synthesis namespace  
            //Step 3: Create an instance of SpeechSynthesizer

            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.Speak("Hello, welcome to the Text to Speech conversion demo in .NET!");

            //Changing Voice
            synth.SelectVoiceByHints(VoiceGender.Female);
            synth.Speak("This is Muskhan and I am currently undergoing WIPRO NGA training.");

            //Change pace
            synth.Rate = 2; // Speed up the speech
            synth.Speak("I am enjoying the training sessions very much.");


        }
    }
}
