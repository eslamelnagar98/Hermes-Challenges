using System;
using System.Text;
using System.Threading.Tasks;

namespace Remove_All_Adjacent_Duplicates_In_String
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Please Enter The Word You Need To Check ");
            var inputWordFromUser = Console.ReadLine();
            var removeDuplicate = await RemoveDuplicates($@"The New Output From You Word Without Any Duplication Is :: {inputWordFromUser}");
            Console.WriteLine(removeDuplicate);
        }

        public async static Task<string> RemoveDuplicates(string sentense)
        {
            if (sentense is null) return null;
            var manyWordsInput = sentense.Split(' ');
            //mutable string (does not create new object every time we add item to it )
            var newWordWithoutDuplicate = new StringBuilder();
            var newSentenseToReturn = new StringBuilder();
            var wordIsAlreadHasNoDuplication = false;
            bool isLenghtOfNewStringToReturnEqualZero = false;
            foreach (var word in manyWordsInput)
            {
                wordIsAlreadHasNoDuplication = false;
                newWordWithoutDuplicate.Remove(0, newWordWithoutDuplicate.Length);
                if (word.Length < 2)
                {
                    wordIsAlreadHasNoDuplication = true;
                    newWordWithoutDuplicate.Append(word);
                }

                for (int i = 0; i < word?.Length && !wordIsAlreadHasNoDuplication; i++)
                {
                    isLenghtOfNewStringToReturnEqualZero = newWordWithoutDuplicate.Length != 0;
                    if (isLenghtOfNewStringToReturnEqualZero && (newWordWithoutDuplicate[newWordWithoutDuplicate.Length - 1] == word[i]))
                        newWordWithoutDuplicate.Remove(newWordWithoutDuplicate.Length - 1, 1);
                    else
                        newWordWithoutDuplicate?.Append(word[i]);
                }
                if (newSentenseToReturn.Length != 0)
                {
                    newSentenseToReturn.Append(" ");
                    newSentenseToReturn.Append(newWordWithoutDuplicate);
                }
                else
                {
                    newSentenseToReturn.Append(newWordWithoutDuplicate);
                }

            }


            return newSentenseToReturn.ToString();
        }
    }
}
