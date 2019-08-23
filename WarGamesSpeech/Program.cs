using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarGamesSpeech {
    class Program {
        static void Main(string[] args) {

            var speach = new System.Speech.Synthesis.SpeechSynthesizer();
            speach.Speak("You mean to tell me!");


        }
    }
}
