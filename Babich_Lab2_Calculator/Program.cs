using System;
using System.IO;

string path_in = "input.txt";
string path_out = "output.txt";
string input_line = "";

#region ЧТЕНИЕ/ПОЛУЧЕНИЕ ИНФОРМАЦИИ
using (StreamReader sr = new StreamReader(path_in, System.Text.Encoding.Default))
{
    input_line = sr.ReadToEnd();
}
#endregion

#region ОБРАБОТКА ИНФОРМАЦИИ

int result = Calculator.Calculate(input_line);

#endregion 

#region ЗАПИСЬ/ВЫВОД
using (StreamWriter sw = new StreamWriter(path_out, false, System.Text.Encoding.Default))
{
    sw.Write(result);
}
#endregion


#region МЕТОДЫ
public class Calculator
{
    public static string[] Parse(string input)
    {
        return input.Split(' ');
    }

    public static int Calculate(string input)
    {
        int first_number;
        int second_number;
        string op = "";
        bool has_equals_sign = false;

        int answer = 0;


        string first_number_string = "";    // Используем массив для цифр, чтобы потом конвертировать его в число
        string second_number_string = "";

        // Разбиваем строку на отдельные символы, и понимаем, какие знаки там присутствуют
        var subs = Calculator.Parse(input);
        foreach (string sub in subs)
        {
            switch (sub)
            {
                case "1":
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                case "8":
                case "9":
                case "0":
                    if (op == "")   // Операция еще не введена, значит вводится первое число
                    {
                        first_number_string += sub;
                    }
                    else            // Операция введена, значит вводится второе число
                    {
                        second_number_string += sub;
                    }
                    break;
                case "+":
                case "-":
                case "/":
                case "*":
                    op = sub;
                    break;
                case "=":
                    has_equals_sign = true;
                    break;
            }
        }

        // Считаем
        if (first_number_string != "")
        {
            first_number = int.Parse(first_number_string);
            answer = first_number;

            if (second_number_string != "")
            {
                second_number = int.Parse(second_number_string);

                if (op != "")
                {
                    answer = second_number;

                    if (has_equals_sign)
                    {
                        switch (op)
                        {
                            case "+":
                                answer = first_number + second_number;
                                break;
                            case "-":
                                answer = first_number - second_number;
                                break;
                            case "/":
                                answer = first_number / second_number;
                                break;
                            case "*":
                                answer = first_number * second_number;
                                break;
                        }
                    }
                }
            }
        }

        return answer;
    }
}
#endregion