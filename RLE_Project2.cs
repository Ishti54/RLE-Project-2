using System;

class Program {
  static void Main () {
    string inputStream = Console.ReadLine();
    int counter = 1;
    string rle = "";
    int length = inputStream.Length;
    
      for (int i = 0;i < inputStream.Length - 1; i++){
        if (inputStream[i] == inputStream[i+1]){
            counter = counter + 1;  
        }else {
            if ( counter > 9 ){
                rle = rle + counter + inputStream[i];
            } else {
                rle = rle + '0' + counter + inputStream[i];
            }
            counter = 1;  
        } 
        
        
      }    
        if ( counter > 9 ){
                rle = rle + counter + inputStream[inputStream.Length - 1];
            } else {
                rle = rle + '0' + counter + inputStream[inputStream.Length - 1];
            }
    
        Console.Write(rle);    
   




  }
}
