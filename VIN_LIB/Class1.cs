namespace VIN_LIB
{
    public class Class1
    {
        string N;
        int m = 0;

        public Class1(string N)
        {
            this.N = N;
        }
        public void CheckVIN()
        {
            for (int i = 0; i <= 5; i++)
            {
                if ((N[i] == '0') || (N[i] == '1') || (N[i] == '2') || (N[i] == '3') || (N[i] == '4') || (N[i] == '5')
                        || (N[i] == '6') || (N[i] == '7') || (N[i] == '8') || (N[i] == '9') || (N[i] == 'A') || (N[i] == 'B')
                        || (N[i] == 'C') || (N[i] == 'D') || (N[i] == 'E') || (N[i] == 'F') || (N[i] == 'G') || (N[i] == 'H')
                        || (N[i] == 'J') || (N[i] == 'K') || (N[i] == 'L') || (N[i] == 'M') || (N[i] == 'N') || (N[i] == 'P')
                        || (N[i] == 'R') || (N[i] == 'S') || (N[i] == 'T') || (N[i] == 'U') || (N[i] == 'V') || (N[i] == 'W')
                        || (N[i] == 'X') || (N[i] == 'Y') || (N[i] == 'Z'))
                {
                    Console.WriteLine("Верный VIN !");
                }
                else
                {
                    Console.WriteLine("Не верный VIN !");
                }
            }
        }
        public void Print() => Console.WriteLine($"Вашь VIN: {N}");
        //static void GetVINCountry()
        //{

        //}
    }
}