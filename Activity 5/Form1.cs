namespace Activity_5
{
    public partial class Activity5 : Form
    {
        public Activity5()
        {
            InitializeComponent();
        }

        //private method to add double the space in the array if needed 
       private string[] getMoreSpace(string[] words)
        {
            int newSize = words.Length * 2;
            string[] newWords = new string[newSize];
            for (int i = 0; i < words.Length; i++)
            {
                newWords[i] = words[i];
            }
            return newWords;
        }

        //private method to trim array to correct size
        private string[] trimArray(string[] words, int numWords)
        {
            string[] newWords = new string[numWords];
            for (int i = 0; i < newWords.Length; i++)
            {
                newWords[i] = words[i];
            }
            return newWords;
        }

        //private method to return words in string format in lower case
        private string formatLowerCaseList(string[] words)
        {
            string wordLowerString = "";
            int spacingCounter = 0;
            for (int i = 0; i < words.Length; i++)
            {
                wordLowerString += words[i] + " ";
                spacingCounter++;
                if (spacingCounter == 5)
                {
                    wordLowerString += System.Environment.NewLine;
                    spacingCounter = 0;
                }
            }

            return wordLowerString;

        }

        //private method to find first alphabetical word
        private string firstAlphabetical(string[] words)
        {
            string currentFirst = words[0];
            for (int i = 1; i < words.Length; i++)
            {
                //if currentFirst is greater than comparator, replace current first with comparator
                if (String.Compare(currentFirst, words[i]) > 0)
                {
                    currentFirst = words[i];
                }
            }

            return currentFirst;
        }

        //private method to find last alphabetical word
        private string lastAlphabetical(string[] words)
        {
            string currentLast = words[0];
            for (int i = 1; i < words.Length; i++)
            {
                //if currentLast is less than comparator, replace current last with comparator
                if (String.Compare(currentLast, words[i]) < 0)
                {
                    currentLast = words[i];
                }
            }

            return currentLast;
        }

        //private method to find the longest word(s)
        private string longestWord(string[] words)
        {
            int[] wordLengths = new int[words.Length];
            int longestLength = 0;

            for (int i = 0; i < wordLengths.Length; i++)
            {
                //collects all the word lengths 
                wordLengths[i] = words[i].Length;
                //tests to find the longest length
                if (wordLengths[i] > longestLength)
                {
                    longestLength = wordLengths[i];
                }
            }

            //add all longest words to longest string
            string longest = "";

            for (int i = 0; i < wordLengths.Length; i++)
            {
                if (wordLengths[i] == longestLength)
                {
                    longest += words[i] + " ";
                }
            }

            longest = longest.Trim();

            return longest;
        }

        private int vowelCount(string word)
        {
            int vowelCount = 0;
            
            //convert word to char array
            char[] wordChars = word.ToCharArray();
            foreach (char c in wordChars)
            {
                //go through each character and if vowel, add to vowelCount
                switch (c)
                {
                    case 'a': vowelCount++; break;
                    case 'e': vowelCount++; break;
                    case 'i': vowelCount++; break;
                    case 'o': vowelCount++; break;
                    case 'u': vowelCount++; break;
                    default : break;
                }
            }

            return vowelCount;
        }

        private string mostVowels(string[] words)
        {
            int[] vowelCounts = new int[words.Length];
            int currentMostVowels = 0;
            for (int i = 0; i < words.Length; i++)
            {
                //call method to count vowels
                vowelCounts[i] = vowelCount(words[i]);

                //if more vowels than current most, change to that
                if (vowelCounts[i] > currentMostVowels)
                {
                    currentMostVowels = vowelCounts[i];
                }
            }

            string mostVowels = "";
            //Add highest amount of vowels to vowel list
            for (int i = 0; i < vowelCounts.Length; i++)
            {
                if (vowelCounts[i] == currentMostVowels)
                {
                    mostVowels += words[i] + " ";
                }
            }

            mostVowels = mostVowels.Trim();

            return mostVowels;
        }

        private void openFileButton_Click(object sender, EventArgs e)
        {
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                //initialize string array for all the words
                string[] words = new string[20];
                try
                {
                    //create a counter for the array size to modify array if needed
                    int arrayCounter = 0;
                    StreamReader inputFile = File.OpenText(openFile.FileName);
                    while (!inputFile.EndOfStream)
                    {
                        
                        //check to see if more space is needed in array
                        if (arrayCounter == words.Length)
                        {
                            words = getMoreSpace(words);
                        }

                        //add word from file
                        words[arrayCounter] = inputFile.ReadLine().Trim().ToLower();

                        //increase arrayCounter
                        arrayCounter++;
                    }

                    inputFile.Close();

                    //check if array needs trimmed
                    if (arrayCounter < words.Length)
                    {
                        words = trimArray(words, arrayCounter);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


                //Setup output string with various breaks for formatting to make it easier to read
                string output = "FROM FILE: " + openFile.FileName + System.Environment.NewLine + System.Environment.NewLine;
                output += "ALL WORDS IN LOWERCASE: " + System.Environment.NewLine;
                output += formatLowerCaseList(words) + System.Environment.NewLine + System.Environment.NewLine;
                output += "FIRST ALPHABETICAL: " + firstAlphabetical(words) + System.Environment.NewLine;
                output += "LAST ALPHABETICAL: " + lastAlphabetical(words) + System.Environment.NewLine + System.Environment.NewLine;
                output += "LONGEST WORD(S): " + System.Environment.NewLine + longestWord(words);
                output += System.Environment.NewLine + System.Environment.NewLine;
                output += "MOST VOWELS: " + System.Environment.NewLine + mostVowels(words);

                outputDataTextbox.Text = output;

                try
                {
                    StreamWriter outputFile;
                    
                    outputFile = File.CreateText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Words Output.txt");

                    outputFile.WriteLine(output);

                    outputFile.Close();

                    MessageBox.Show("Written text file to Documents Folder!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


            }
            else
            {
                MessageBox.Show("Operation Canceled");
            }
        }
    }
}