//05 May 2024 - Start project, wrote one bad comment
//06 May 2024 - Wrote another bad comments 

// Compute area of triangle
double s=(a + b + c)/2
double area = sqrt(s*(s-a)*(s-b)*(s-c));


// Actions /////////////////////////////////////////////////////////////////////////////////////////


public bool CheckUser(string name, string surname, string cardnum, int cardpin)
{
    //Regex regexName = new Regex("^[А-ЗІЙ-ХЩЮЯ][а-яіїйь']+(-[А-ЗІЙ-ХЩЮЯ][а-яіїйь']+)?$", RegexOptions.Compiled);
    //Regex regexSurname = new Regex("^([А-ЯІЇЄЙ][а-я]+)$", RegexOptions.Compiled);
    Regex regexCardNumber = new Regex("^\\d{16}$", RegexOptions.Compiled);
    Regex regexCardPinCode = new Regex("^\\d{4}$", RegexOptions.Compiled);
    //Match matchName = regexName.Match(name);
    //Match matchSurname = regexSurname.Match(surname);
    Match matchCardNumber = regexCardNumber.Match(cardnum);
    Match matchCardPinCode = regexCardPinCode.Match(cardpin.ToString());

    if (//!matchName.Success|| !matchSurname.Success || 
    !matchCardNumber.Success || !matchCardPinCode.Success)
    {
        AuthorizationEvent?.Invoke(this, new AccountMessagesEvent("Не правильний ввід даних"));
        return false;
    }
    else
    {
        AuthorizationEvent?.Invoke(this, new AccountMessagesEvent("Перевірка даних"));
        return true;
    }

}


// Another actions /////////////////////////////////////////////////////////////////////////////////////////


//Додати кошти на свою картку
public bool AddMoneyOnMyCard(double sum, AutomatedTellerMachine machine)
{
    balance += sum;
    machine.MachineTotalMoney += sum;
    AddMoneyEvent?.Invoke(this, new AccountOperationMessagesEventArgs($"На вашу карту додано {sum} грн", sum));
    string theme = "Додавання коштів";
    string plot = $"На вашу карту додано {sum} грн";
    CheckIsletter(theme, plot);
    return true;
}

//Date: Mon 6 May 2024
double sum = a + b;



// The name
private string name;
// The version
private string version;
//The licenceName
private string licenceName;
// The version
private string info;
