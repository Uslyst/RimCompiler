using Button = System.Windows.Forms.Button;

namespace RimCompiler
{
    public static class Prompt
    {
        public static DialogResult ShowDialog(string title, string message, string caption, out string outputText)
        {
            Form prompt = new Form()
            {
                Width = 400,
                Height = 180,
                FormBorderStyle = FormBorderStyle.FixedSingle,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen
            };

            Label titleLabel = new Label()
            {
                Left = 10,
                Top = 10,
                Width = 360,
                Text = title,
                Font = new Font("Segoe UI", 10, FontStyle.Bold)
            };

            Label messageLabel = new Label()
            {
                Left = 10,
                Top = 35,
                Width = 360,
                Text = message
            };

            TextBox textBox = new TextBox() { Left = 10, Top = 60, Width = 360 };

            Button confirmation = new Button() { Text = "OK", Left = 210, Width = 80, Top = 100, DialogResult = DialogResult.OK };
            Button cancel = new Button() { Text = "Cancel", Left = 290, Width = 80, Top = 100, DialogResult = DialogResult.Cancel };

            confirmation.Click += (sender, e) => { prompt.Close(); };
            cancel.Click += (sender, e) => { textBox.Text = null; prompt.Close(); };

            prompt.Controls.Add(titleLabel);
            prompt.Controls.Add(messageLabel);
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(cancel);
            prompt.AcceptButton = confirmation;
            prompt.CancelButton = cancel;

            var dialogResult = prompt.ShowDialog();

            outputText = textBox.Text;
     
            return dialogResult;
        }
    }

}
