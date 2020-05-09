using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NPC_Lore_Generator
{ 

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

            public override void Handle(Receiver receiver)
            {
                if (receiver.Condition == 0)
                {
                    ContentGraph contentGraphRandom = new ContentGraph(random.Next(1, 9));
                    Form1.kludge.richTextBox2.Text = contentGraphRandom.ExtractContent();
                }
                else
                {
                    ContentGraph contentGraphExact = new ContentGraph(Form1.kludge.customTrackBar0.currentTickPosition);
                    Form1.kludge.richTextBox2.Text = contentGraphExact.ExtractContent();
                }

                if (Successor != null)
                    Successor.Handle(receiver);
            }
        }


    }
}
