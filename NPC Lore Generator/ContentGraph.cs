using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPC_Lore_Generator
{



    public class ContentGraph
    {
        public ContentGraph(int index)
        {
            Content[] contentArray = new Content[10];
            contentArray[1] = new Content("You see a Desert", "You see the lands of sands and a scorching sun", "You see a sandstorm and pray to survive");
            contentArray[2] = new Content("You see a Coast", "You see surging waves under seagulls clamor");
            contentArray[3] = new Content("You see a Forest", "Among the neverending trees you hear birds, you see sunbeams going through treetops, you are one with the nature", "You are in a forest. It is quiet here. Every sound here has a weight. Bushes, leaves, birds - you can spot every minor detail.");
            contentArray[4] = new Content("You see a Steppe", "Steppe. Having seen this endless sky once, you cannot forget it. This is your true homeland", "Steppe. You see a carpet of grass and hills going long behind the horizon. You can feel yourself truly free here.");
            contentArray[5] = new Content("You see a Grassland", "You see a beutiful grassland. There are is everything true beauty needs. Birds and butterflies, trees and fields, farms far away. Everything in perfect harmony.");
            contentArray[6] = new Content("You see a Rainforest", "You are in a rainforest. It isn't as friendly as regular one. Everything either moves here or keeps waiting for something to move.");
            contentArray[7] = new Content("You see a Mountain", "You see a mountain and you are captured by its beauty. Triumph of the nature's art it captivates with a stunning landscape", "You are on a mountain. It seems like you can observe the whole world as it is, more than ever could.");
            contentArray[8] = new Content("You see an Island", "You are on an island. Sometimes it is calm and nice here, sometimes storm busts in. You start to believe the Sea itself has its own mood.");
            contentArray[9] = new Content("You see a Tundra", "You see snowland. Everywhere you go there is only eternal snow. Even the nature itself is unsure about living here. This is a challenge worthy of a true survivor");
            CurrentText = contentArray[index].ContentText;
        }

        // Current number to process to get the text.
        public string CurrentText;

        // Takes CurrentGraph int and extracts node's random string
        public string ExtractContent()
        {
            return CurrentText;
        }


        // Initializes graphs with your sentences one of which is chosen randomly. Up to 3 sentences yet. Maybe add 4 and 5 content.
        public class Content
        {
            private string contentText1;
            private string contentText2;
            private string contentText3;
            //private string ContentText4;
            //private string contentText5;
            private string[] contentText;


            public Content(string contentText1, string contentText2, string contentText3)
            {
                this.contentText1 = contentText1;
                this.contentText2 = contentText2;
                this.contentText3 = contentText3;
                this.contentText = new string[3] {contentText1, contentText2, contentText3 };
            }

            public Content(string contentText1, string contentText2)
            {
                this.contentText1 = contentText1;
                this.contentText2 = contentText2;
                this.contentText = new string[2] { contentText1, contentText2 };
            }

            public Content(string contentText1)
            {
                this.contentText1 = contentText1;
                this.contentText = new string[1] { contentText1 };
            }

            public string ContentText
            {
                get
                {
                    Random random = new Random();
                    int i = random.Next(contentText.Length);
                    return contentText[i];
                }

                set
                {
                    contentText1 = value;
                    contentText2 = value;
                    contentText3 = value;
                }
            }

        }
    }
}
