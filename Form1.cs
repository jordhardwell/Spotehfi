using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private string currentSong, searchTerm;  
        
        public Form1()
        {
            InitializeComponent();            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private bool openSpotify(string uri) // Open spotify URIs
        {
            try
            {
                using (Process spotify = new Process())
                {
                    spotify.StartInfo.FileName = uri;
                    spotify.Start();
                    return true;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Whoops");
                return false;
            }
        } 

        private void npLink_Click(object sender, EventArgs e) //Concats Artist and Song title to generate search url.
        {
            string toClip = "spotify:search:" + nowPlayingArtist.Text + nowPlayingSong.Text;
            Clipboard.SetText(toClip.Replace(" ", "+"));
        }

        private string convertLink(string link) // Converts spotify open urls into URIs.
        {
            // Sample input https://open.spotify.com/track/5SiZJoLXp3WOl3J4C8IK0d?si=VWoGtyBGS4mgM6A9rN7fAQ
            string input = link; 
            String regexTrack = "(?:/track)\\S*";
            String regexPlaylist = "(?:/playlist)\\S*";
            String regexArtist = "(?:/artist)\\S*";
            String regexAlbum = "(?:/album)\\S*";
            String regexUser = "(?:/user)\\S*";
            // a mess. 
            if (Regex.Match(input, regexTrack).Success) {
                input = Regex.Match(input, regexTrack).ToString();
            }else if (Regex.Match(input, regexPlaylist).Success)
            {
                input = Regex.Match(input, regexPlaylist).ToString();
            }else if (Regex.Match(input, regexArtist).Success)
            {
                input = Regex.Match(input, regexArtist).ToString();
            }else if (Regex.Match(input, regexAlbum).Success)
            {
                input = Regex.Match(input, regexAlbum).ToString();
            }else if (Regex.Match(input, regexUser).Success)
            {
                input = Regex.Match(input, regexUser).ToString();
            }
            if (input.Contains("?")) //Regex is hard
            {
                char question = '?';
                string[] output = input.Split(question);
                input = output[0];
            }

            input = input.Replace('/', ':');

            if (!input.Contains("spotify")) {
                input = "spotify" + input;
            }
            
            return input;
        }

        private void searchInput_TextChanged(object sender, EventArgs e) // Updates Clipboard based on user input; V.Bad.
        {
            if (searchInput.TextLength > 2) {
                searchTerm = searchInput.Text;
                Clipboard.SetText(searchTerm);
            }
        } 

        private void goToLink_Click(object sender, EventArgs e) // Function to open spotify uris.
        {
            string str = Clipboard.GetText();
            if (str.Contains("spotify:"))
            {
                openSpotify(str);  
            }
        }

        private void cleanLinkBtn_Click(object sender, EventArgs e)
        {
            convertLink(Clipboard.GetText());
        }

        private bool detectSpotifyLink(string data) // Detect if Clipboard contains 'spotify'
        {
            return (Clipboard.GetText().Contains("spotify") ? true : false);
        } 

        private void searchSong_Click(object sender, EventArgs e) // Search for either now playing or input term
        {
            string preUri = $"spotify:search:{searchTerm}";
            openSpotify(preUri);
        }

        private void timer1_Tick(object sender, EventArgs e) // Checks for Spotify process, gets active title.
        {            
            Process[] processList = Process.GetProcessesByName("Spotify");
            foreach (Process process in processList)
            {
                if (!String.IsNullOrEmpty(process.MainWindowTitle) && process.ProcessName == "Spotify")
                {
                    currentSong = process.MainWindowTitle;
                    if (currentSong != nowPlayingSong.Text) {
                        string[] details = currentSong.Split('-');
                        if (details.Length > 1) {
                            nowPlayingSong.Text = details[1];
                            nowPlayingArtist.Text = details[0];
                        }                          
                    }                    
                }
            }
        }

        private void clipUpdate_Tick(object sender, EventArgs e) //Timer to detect clipboard updates.
        {
            string clipData = Clipboard.GetText(); // Stores clip data
            if (detectSpotifyLink(clipData) == true)
            {                
                if (clipData.Length > 90) {
                    //Spotify Link is 53 chars long plus buffer room for junk in the copy.
                    string[] links = clipData.Split(new[] { Environment.NewLine }, StringSplitOptions.None); //Splits the clipboard by line breaks, WIP.
                    foreach (string link in links) {

                    }

                }
            }
        }

    }
}




