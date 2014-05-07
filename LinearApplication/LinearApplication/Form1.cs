using System;
using System.Windows.Forms;

namespace LinearApplication {
    public partial class Form1 : Form {
        private int memory;
        private bool oper;

        private Button plusButton;
        private Button minusButton;
        private Button resultButton;
        private Button ceButton;

        public Form1() {
            InitializeComponent();

            InitFields();
            CreateControls();
            SubscribeOnEvents();
        }

        private void SubscribeOnEvents() {
            plusButton.Click += PlusButtonOnClick;
            minusButton.Click += MinusButtonOnClick();
            resultButton.Click += ResultButtonOnClick();

            var textbox1 = CreateTextBox();
            ceButton.Click += CeButtonOnClick(textbox1);

            textbox1.Leave += TextboxOnLeave(textbox1);
        }

        private void PlusButtonOnClick(object sender, EventArgs e) {
            oper = true;
            CreateTextBox().Text = "0";
        }


        private EventHandler TextboxOnLeave(TextBox textbox1) {
            return (s, a) => {
                memory = oper
                    ? memory + Int32.Parse(textbox1.Text)
                    : memory - Int32.Parse(textbox1.Text);
            };
        }

        private EventHandler CeButtonOnClick(TextBox textbox1) {
            return (s, a) => {
                textbox1.Text = "0";
                memory = 0;
            };
        }

        private EventHandler ResultButtonOnClick() {
            return (s, a) => { CreateTextBox().Text = memory.ToString(); };
        }

        private EventHandler MinusButtonOnClick() {
            return (s, a) => {
                oper = false;
                CreateTextBox().Text = "0";
            };
        }

        private void InitFields() {
            memory = 0;
            oper = true;
        }

        private void CreateControls() {
            Controls.Add(CreateTextBox());

            plusButton = CreateButton(0, "+");
            minusButton = CreateButton(50, "-");
            resultButton = CreateButton(100, "=");
            ceButton = CreateButton(150, "CE");
        }

        private Button CreateButton(int offset, string text) {
            var button = new Button {
                Text = text,
                Width = 50,
                Height = 50,
                Top = 50,
                Left = offset
            };

            Controls.Add(button);

            return button;
        }

        private static TextBox CreateTextBox() {
            var textbox = new TextBox {
                Text = "0",
                TextAlign = HorizontalAlignment.Right,
                Width = 100,
                Height = 30
            };
            return textbox;
        }
    }

    public enum Operation {
        plus,
        minus
    }
}