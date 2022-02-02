namespace Lernprogramm3_Matchinggame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void RefreshWindowTitle()
        {
            Text = string.Format("Lernprogramm 3: MatchingGame [Moves: {0}]", Math.Floor((double)moves / 2));
        }

        Random rdm = new();

        List<string> icons = new()
        {
            "!",
            "!",
            "N",
            "N",
            ",",
            ",",
            "k",
            "k",
            "b",
            "b",
            "v",
            "v",
            "w",
            "w",
            "z",
            "z"
        };

        Dictionary<Control, ControlIconDefinition> controlIcons = new();

        Control flipped1;
        Control flipped2;

        int moves = 0;
        int foundCards = 0;
        int cardsToFind;
        private void Form1_Load(object sender, EventArgs e)
        {
            cardsToFind = icons.Count;
            foreach (Control con in tableLayoutPanel1.Controls)
            {
                int nextIndex = rdm.Next(icons.Count);

                string icon = icons[nextIndex];
                icons.RemoveAt(nextIndex);

                con.Text = "";
                controlIcons[con] = new ControlIconDefinition() { Icon = icon };

                con.Click += (_, _) =>
                {
                    if (flipped1 != null && flipped2 != null)
                    {
                        flipped1.BackColor = Color.CornflowerBlue;
                        flipped2.BackColor = Color.CornflowerBlue;
                        flipped1.Text = "";
                        flipped2.Text = "";
                        flipped1 = null;
                        flipped2 = null;
                    }
                    if (controlIcons[con].Found)
                    {
                        return;
                    }

                    moves++;
                    RefreshWindowTitle();

                    con.BackColor = Color.Orange;

                    if (flipped1 == null)
                    {
                        flipped1 = con;

                        flipped1.Text = controlIcons[flipped1].Icon;

                        return;
                    }
                    if (flipped2 == null)
                    {
                        if (flipped1 == con)
                        {
                            MessageBox.Show("Nicht schummeln!", "Mogelpott");
                            return;
                        }
                        flipped2 = con;

                        flipped2.Text = controlIcons[flipped2].Icon;

                        if (flipped2.Text == flipped1.Text)
                        {
                            // success
                            foreach (Control cont in new Control[] { flipped1, flipped2 })
                            {
                                cont.BackColor = Color.Green;
                                controlIcons[cont].Found = true;
                            }
                            flipped1 = null;
                            flipped2 = null;

                            foundCards += 2;

                            if (foundCards >= cardsToFind)
                            {
                                MessageBox.Show(string.Format("Herzlichen Glühstrumpf! Du hast das Memory in nur {0} Zügen ausgeräumt!", Math.Floor((double)moves / 2)), "Yeehaw!");
                            }
                        }
                    }
                };
            }
        }
    }

    class ControlIconDefinition
    {
        public string Icon { get; set; }
        public bool Found { get; set; } = false;
    }
}