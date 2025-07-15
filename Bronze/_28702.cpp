#include <iostream>
#include <string>

using namespace std;

int main()
{
	int n;
	string s, ans = "";
	for (int i = 0; i < 3; i++)
	{
		cin >> s;

		if (ans != "") continue;
		if (s[0] == 'F' || s[0] == 'B') continue;

		n = stoi(s) + 3 - i;
		if (n % 3 == 0 && n % 5 == 0)
			ans = "FizzBuzz";
		else if (n % 3 == 0 && n % 5 != 0)
			ans = "Fizz";
		else if (n % 3 != 0 && n % 5 == 0)
			ans = "Buzz";
		else if (n % 3 && n % 5)
			ans = to_string(n);
	}

	cout << ans;
	return 0;
}
