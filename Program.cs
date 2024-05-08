object[] mixedArray = new object[3];

mixedArray[0] = "Hello";
mixedArray[1] = 2;
mixedArray[2] = ":-)";


List<object> resultArray = new List<object>();
for (int i = 0; i < mixedArray.Length; i++){
    if (mixedArray[i].ToString().Length >= 4){
            resultArray.Add(mixedArray[i]);
        }
}

        foreach (object item in resultArray){
            Console.WriteLine(item);
        }