using Task1;

var result = Matrix.MatrixIniciale();
Matrix matrix = new Matrix(result);
Console.WriteLine(matrix.ToString());

var result2 = Matrix.MatrixIniciale();
Matrix matrix2 = new Matrix(result2);
Console.WriteLine(matrix2.ToString());

//var result3 = matrix + matrix2;
//var result4 = matrix - matrix2;
//var result5 = matrix * matrix2;
//Console.WriteLine(result5.ToString());


//var result6 = matrix.Equals(matrix2);
//Console.WriteLine(result6.ToString());

var result7 = -matrix;
Console.WriteLine(result7.ToString());