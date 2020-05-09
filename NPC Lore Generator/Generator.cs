using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NPC_Lore_Generator
{ 
    // God pls fkin kill me im so tired of this shitty net framework.
    // I want to die, help me.
    // Somebody end my suffering.
    // Also burn the main office of microsoft company

    public class Generator
    {
        public Form1 form1;

        // Extracts generator data from visual form
        public class Receiver
        {
            public int Condition { get; set; }
            public Receiver(int condition)
            {
                Condition = condition;
            }
        }

        // Responsibility Chain
       public abstract class GenerateHandler
        {
            public GenerateHandler Successor { get; set; }
            public abstract void Handle(Receiver receiver);
        }

        // Phase 1 generate
        public class Phase1Handler : GenerateHandler
        {
            Random random = new Random();
            //ContentGraph contentGraph = new ContentGraph();

            public override void Handle(Receiver receiver)
            {
                if (receiver.Condition == 0)
                {
                    //Form1.kludge.richTextBox2.Text += "Bwah Blah brrrr";
                    //contentGraph.CurrentGraph = random.Next(1, 9);
                    // Form1.kludge.richTextBox2.Text = contentGraph.ExtractContent();

                    ContentGraph contentGraphRandom = new ContentGraph(random.Next(1, 9));
                    Form1.kludge.richTextBox2.Text = contentGraphRandom.ExtractContent();

                    //Form1._Form1.TextUpdate("Net framework is complete garbage shit");
                }
                else
                {
                    //Form1.kludge.richTextBox2.Text += 
                    //ContentGraph.Node1 node1 = new ContentGraph.Node1();

                    ContentGraph contentGraphExact = new ContentGraph(Form1.kludge.customTrackBar0.currentTickPosition);
                    Form1.kludge.richTextBox2.Text = contentGraphExact.ExtractContent();

                    // ContentGraph[] contentGraphs = new ContentGraph[9];

                   /// contentGraph.CurrentGraph = Form1.kludge.customTrackBar0.currentTickPosition;
                    
                    //
                    //Form1._Form1.TextUpdate("Net framework is fkin shit destroy its builders");
                }

                // throw new NotImplementedException();
                if (Successor != null)
                    Successor.Handle(receiver);
            }
        }


    }
}
