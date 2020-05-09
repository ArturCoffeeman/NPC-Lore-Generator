using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPC_Lore_Generator
{



    public class ContentGraph
    {

        /*Node1 node1 = new Node1();
        Node2 node2 = new Node2();
        Node3 node3 = new Node3();
        Node4 node4 = new Node4();
        Node5 node5 = new Node5();
        Node6 node6 = new Node6();
        Node7 node7 = new Node7();
        Node8 node8 = new Node8();
        Node9 node9 = new Node9();*/

        //Nodes[] nodes = new Nodes[Node1, Node2, Node3, Node4, Node5, Node6, Node7, Node8, Node9];

        //Object[] nodes = new object[9] {Node1 };



        //Nodes[] = {Node1, Node2, Node3, Node4, Node5, Node6, Node7, Node8, Node9};

        //ContentGraph[] nodes = new ContentGraph[2];    
        //nodes[1] = new ContentGraph();

        /* ContentGraph[] arrayGraphs<ContentGraph>(int length) where ContentGraph : new()
         {
             ContentGraph[] nodes = new ContentGraph[length];
             for (int i = 0; i < length; i++ )
             {
                 nodes[i] = new ContentGraph();
             }
             return nodes;
         }*/

        //Nodes[] nodes = arrayGraphs


        //var nodes = new ContentGraph[2].Select(h => new ContentGraph()).ToArray();


        // ContentGraph[] nodes = new ContentGraph[3];


        
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





        //public int CurrentGraph;  // Current number to process to get the text.
        public string CurrentText;


 
        // Takes CurrentGraph int and extracts node's random string
        public string ExtractContent()
        {
            return CurrentText;
        }


        // Initializes graphs with your sentences one of which is chosen randomly. Up to 3 sentences yet.
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
                    //contentText = { contentText1 = value; }
                    //contentText = new string[3] { contentText1 = value, contentText2 = value, contentText3 = value };
                   // string[] contentText = { contentText1 = value, contentText2 = value, contentText2 = value };
                }
            }

        }

        /*public class Node1
        {
            /*string ContentText1 = "You see a Desert";
            string ContentText2 = "You see some sands and a flaming sun";
            string ContentText3 = "You see a sandstorm and pray to survive";
            
            string[] ContentText = { "You see a Desert", "You see some sands and a flaming sun", "You see a sandstorm and pray to survive" };


            public string getContent()
            {
                Random random = new Random();
                int index = random.Next(ContentText.Length);
                return ContentText[index];   
            }

        }

        public class Node2
        {
            public string ContentText1 = "You see a Coast";
        }

        public class Node3
        {
            public string ContentText1 = "You see a Forest";
        }

        public class Node4
        {
            public string ContentText1 = "You see a Steppe";
        }

        public class Node5
        {
            public string ContentText1 = "You see a Grassland";
        }

        public class Node6
        {
            public string ContentText1 = "You see a Rainforest/Swamp";
        }

        public class Node7
        {
            public string ContentText1 = "You see a Mountain hill";
        }

        public class Node8
        {
            public string ContentText1 = "You see Island among the seas";
        }

        public class Node9
        {
            public string ContentText1 = "You see snow carpet everywhere. Not a sound can go through";
        }*/
    }
}
