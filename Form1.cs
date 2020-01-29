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
        private string currentSong, npSong, npArtist, searchTerm;
        private Process[] processList;
        
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // nowPlayingSong.Text = currentSong;
        }

        private bool openSpotify(string uri)
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
        } // Open spotify URIs

        private void button1_Click(object sender, EventArgs e)
        {
                //convertLink(Clipboard.GetText());

                //System.Windows.Forms.Application.Exit();
        }//Exit Button

        private void npLink_Click(object sender, EventArgs e)
        {
            string toClip = "spotify:search:" + nowPlayingArtist.Text + nowPlayingSong.Text;
            Clipboard.SetText(toClip.Replace(" ", "+"));
        }

        private string convertLink(string link) {
            // Sample input https://open.spotify.com/track/5SiZJoLXp3WOl3J4C8IK0d?si=VWoGtyBGS4mgM6A9rN7fAQ
            string input = link; 
            String regexTrack = "(?:/track)\\S*";
            String regexPlaylist = "(?:/playlist)\\S*";
            String regexArtist = "(?:/artist)\\S*";
            String regexAlbum = "(?:/album)\\S*";
            String regexUser = "(?:/user)\\S*";

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
            if (input.Contains("?"))
            {
                char question = '?';
                string[] output = input.Split(question);
                input = output[0];
            }

            //Clipboard.SetText(input);
            input = input.Replace('/', ':');
            if (!input.Contains("spotify")) {
                input = "spotify" + input;
            }
            
            Clipboard.SetText(input);
            return input;

            //Regex removeURL = new Regex(@"\.*$\");
            //Regex removePromo = new Regex(@"?.*$\");

            //string text = input.Replace(input, "(?:/track)S*");
        }

        private void searchInput_TextChanged(object sender, EventArgs e)
        {
            searchTerm = searchInput.Text;
            Clipboard.SetText(searchTerm);
        } // Updates Clipboard based on user input

        private void goToLink_Click(object sender, EventArgs e)
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

        private bool detectSpotifyLink(string data)
        {
            if (data.Contains("spotify"))
            {
                return true;
            }
            else
            {
                return false;
            }
        } // Detect if Clipboard contains 'spotify'

        private void searchSong_Click(object sender, EventArgs e) // Search for either now playing or input term
        {
            string preUri = $"spotify:search:{searchTerm}";
            openSpotify(preUri);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {            
            processList = Process.GetProcessesByName("Spotify");
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
        } // Updates now playing from Spotify

        private void clipUpdate_Tick(object sender, EventArgs e) //Timer to detect clipboard updates.
        {
            string clipData = Clipboard.GetText(); // Stores clip data
            if (detectSpotifyLink(clipData) == true)
            {
                clipboard.Text = clipData;
                if (clipboard.Text.Length > 90) {
                    //Spotify Link is 90 chars long, most likely a batch.
                    string[] links = clipboard.Text.Split(
                        new[] { Environment.NewLine },
                        StringSplitOptions.None
                    );
                    foreach (string link in links) {

                    }

                }
            }
        }

    }
}




