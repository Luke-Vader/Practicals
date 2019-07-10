static void Main(string[] args) {
    string[] country = {"USA", "UK", "Russia", "India"};
    int max = country.Max(x => x.Length);
    string maxCountry = country.Where(x => x.Lenth == max).ToString();
    Console.WriteLine("Max Country: " + maxCountry);
    Console.ReadKey();

}