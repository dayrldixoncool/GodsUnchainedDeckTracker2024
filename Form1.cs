using System;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GodsUnchainedDeckTracker
{
    public partial class GUDECKTRACKER : Form
    {
        private string? lastOpponentId = null; // Store the last opponent ID to detect changes

        public GUDECKTRACKER()
        {
            InitializeComponent();

            // Load the saved checkbox value from the settings
            checkBox1.Checked = Properties.Settings.Default.AutoOpenOpponentProfile;

            StartLogChecking();
        }

        private async void StartLogChecking()
        {
            // Automatically get the Windows username
            string userName = Environment.UserName;

            // Set the path to the debug.log file dynamically
            string logFilePath = $@"C:\Users\{userName}\AppData\LocalLow\Immutable\gods\debug.log";

            DateTime lastModifiedTime = DateTime.MinValue; // To track the last modified time
            bool isFirstCheck = true; // Flag to indicate if it's the first check

            // Continuously monitor the log file for updates
            while (true)
            {
                try
                {
                    // Check if the log file exists
                    if (File.Exists(logFilePath))
                    {
                        // Get the last write time of the log file
                        DateTime currentModifiedTime = File.GetLastWriteTime(logFilePath);

                        // On the first check, just set the lastModifiedTime
                        if (isFirstCheck)
                        {
                            lastModifiedTime = currentModifiedTime; // Set the initial modified time
                            isFirstCheck = false; // Set the flag to false after the first check
                        }
                        else
                        {
                            // Check if the log file has been modified since the last check
                            if (currentModifiedTime > lastModifiedTime)
                            {
                                // Update the last modified time
                                lastModifiedTime = currentModifiedTime;

                                // Read the log data
                                string logData = await File.ReadAllTextAsync(logFilePath);
                                ExtractAndDisplayIDs(logData); // Process the new log data
                            }
                        }
                    }
                }
                catch (FileNotFoundException)
                {
                    // Handle the specific case where the file was deleted
                    // Do nothing, just continue to the next check
                }
                catch (IOException)
                {
                    // Handle other IO exceptions (e.g., access denied, file being used by another process)
                    // Do nothing, just continue to the next check
                }
                catch (Exception ex)
                {
                    // Handle any other exceptions silently or log them
                    Console.WriteLine(ex.Message); // Or use a logging framework
                }

                // Wait for a bit before checking the log file again
                await Task.Delay(200); // Check every 200 milliseconds
            }
        }

        private void ExtractAndDisplayIDs(string logData)
        {
            string? yourId = null;
            string? yourNick = null; // New variable for your nickname
            string? opponentId = null;
            string? opponentNick = null;

            // Updated regex pattern to match the player information from the log
            var playerInfoPattern = new Regex(@"p:PlayerInfo\(apolloId:\s*(\d+),.*?nickName:\s*(.*?),.*?o:PlayerInfo\(apolloId:\s*(\d+),.*?nickName:\s*(.*?)(?:,|\))");
            // Regex pattern to detect the start of a new match
            var matchStartPattern = new Regex(@"\[.*?\]: Log]: Start");

            foreach (var line in logData.Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries))
            {
                if (matchStartPattern.IsMatch(line))
                {
                    // Reset IDs and nicknames when a new match starts
                    yourId = null;
                    yourNick = null; // Reset your nickname
                    opponentId = null;
                    opponentNick = null;
                    continue; // Move to the next line
                }

                var match = playerInfoPattern.Match(line);
                if (match.Success)
                {
                    yourId = match.Groups[1].Value; // Your ID
                    yourNick = match.Groups[2].Value; // Your Nickname
                    opponentId = match.Groups[3].Value; // Opponent ID
                    opponentNick = match.Groups[4].Value; // Opponent Nickname

                    // Update the labels with the extracted IDs and names
                    this.Invoke((MethodInvoker)delegate
                    {
                        YourIdLabel.Text = $"{yourId}";
                        YourNicknameLabel.Text = $"{yourNick}"; // Update your nickname label
                        OpponentIdLabel.Text = $"{opponentId}";
                        OpponentNickLabel.Text = $"{opponentNick}";

                        // Make YourIdLabel clickable like a hyperlink
                        YourIdLabel.ForeColor = System.Drawing.Color.Blue;
                        YourIdLabel.Font = new System.Drawing.Font(YourIdLabel.Font, System.Drawing.FontStyle.Underline);
                        YourIdLabel.Cursor = Cursors.Hand;

                        // Make OpponentIdLabel clickable like a hyperlink
                        OpponentIdLabel.ForeColor = System.Drawing.Color.Blue;
                        OpponentIdLabel.Font = new System.Drawing.Font(OpponentIdLabel.Font, System.Drawing.FontStyle.Underline);
                        OpponentIdLabel.Cursor = Cursors.Hand;

                        // Store your ID in the label's Tag property
                        YourIdLabel.Tag = yourId;

                        // Store opponent ID in the label's Tag property
                        OpponentIdLabel.Tag = opponentId;

                        // Detach previous click event handlers
                        YourIdLabel.Click -= YourIdLabel_Click;
                        OpponentIdLabel.Click -= OpponentIdLabel_Click;

                        // Attach the click event handler for your ID
                        YourIdLabel.Click += YourIdLabel_Click;

                        // Attach the click event handler for the opponent ID
                        OpponentIdLabel.Click += OpponentIdLabel_Click;

                        // Check if the opponent ID has changed and if checkBox1 is checked
                        if (lastOpponentId != opponentId && checkBox1.Checked)
                        {
                            lastOpponentId = opponentId; // Update the last opponent ID
                            OpenOpponentProfile(opponentId); // Automatically open the opponent's profile
                        }
                    });

                    break; // Exit the loop after finding the information
                }
            }
        }

        // Named method to handle the click event for your ID label
        private void YourIdLabel_Click(object sender, EventArgs e)
        {
            if (sender is Label label)
            {
                OpenYourProfile(label.Tag?.ToString()); // Assuming yourId is stored in Tag
            }
        }

        // Named method to handle the click event for opponent ID label
        private void OpponentIdLabel_Click(object sender, EventArgs e)
        {
            if (sender is Label label)
            {
                OpenOpponentProfile(label.Tag?.ToString()); // Assuming opponentId is stored in Tag
            }
        }

        // Method to open your profile in the browser
        private async void OpenYourProfile(string? yourId)
        {
            if (string.IsNullOrEmpty(yourId)) return; // Ensure yourId is valid

            try
            {
                // First, open the ad link in the default web browser
                // string adUrl = "https://zireemilsoude.net/4/8260364";
                string adUrl = "https://www.cpmrevenuegate.com/xjpmach1?key=0391ec38aabdbaf4dd2a994ae2e7123c";
                Process.Start(new ProcessStartInfo(adUrl) { UseShellExecute = true });

                // Wait for a short delay before opening your profile link
                await Task.Delay(100); // 1-second delay

                // Then, open your profile on gudecks.com
                string profileUrl = $"https://gudecks.com/meta/player-stats?userId={yourId}";
                Process.Start(new ProcessStartInfo(profileUrl) { UseShellExecute = true });
            }
            catch
            {
                // Handle exceptions silently
            }
        }

        // Method to open the opponent profile in the browser
        private async void OpenOpponentProfile(string? opponentId)
        {
            if (string.IsNullOrEmpty(opponentId)) return; // Ensure opponentId is valid

            try
            {
                // First, open the ad link in the default web browser
                // string adUrl = "https://zireemilsoude.net/4/8260364";
                string adUrl = "https://www.cpmrevenuegate.com/xjpmach1?key=0391ec38aabdbaf4dd2a994ae2e7123c";
                Process.Start(new ProcessStartInfo(adUrl) { UseShellExecute = true });

                // Wait for a short delay before opening the opponent profile link
                await Task.Delay(100); // 1-second delay

                // Then, open the opponent profile on gudecks.com
                string profileUrl = $"https://gudecks.com/meta/player-stats?userId={opponentId}";
                Process.Start(new ProcessStartInfo(profileUrl) { UseShellExecute = true });
            }
            catch
            {
                // Handle exceptions silently
            }
        }

        // Checkbox CheckedChanged event to save the checkbox state
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // Save the current checkbox state to the settings
            Properties.Settings.Default.AutoOpenOpponentProfile = checkBox1.Checked;
            Properties.Settings.Default.Save(); // Save the changes to the settings file
        }

        private void label4_Click(object sender, EventArgs e)
        {
            // Another label click event logic (if any)
        }

        private void label5_Click(object sender, EventArgs e)
        {
            // Another label click event logic (if any)
        }

        private void label7_Click(object sender, EventArgs e)
        {
            // Another label click event logic (if any)
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
