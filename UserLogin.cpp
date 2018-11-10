/*
 * Pablo Sánchez Alonso
 * Program that asks for a username and password
 *  and allows a maximum of three attempts
 */
 
#include <iostream>
using namespace std;

int main()
{
    string user , password , correctUser = "admin" , correctPassword = "1111";
   
    int attemps = 0;
    do
    {
        cout << "Introduce your user" << endl;
        cin >> user;
        
        cout << "Introduce your password" << endl;
        cin >> password;
        
        attemps++;
        
        cout << endl;
    }
    while(( user != correctUser || password != correctPassword) 
            && (attemps < 3 ));
            
    if ( user != correctUser || password != correctPassword )
    {
        cout << "You have exceeded the number of attempts try again later";
    }
}
