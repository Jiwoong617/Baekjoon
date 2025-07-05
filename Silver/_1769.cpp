#include <iostream>
#include <string>

using namespace std;

int main()
{
	string s; cin >> s;
	int cnt = 0, n = 0;

	if (s.length() < 2)
	{
		n = s[0] - '0';
		cout << cnt << '\n';
		cout << (n % 3 == 0 ? "YES" : "NO");
		return 0;
	}

	while (1)
	{
		cnt++;
		n = 0;
		for (int i = 0; i < s.length(); i++)
			n += s[i] - '0';

		s = to_string(n);
		if (n < 10)
		{
			cout << cnt << '\n';
			cout << (n % 3 == 0 ? "YES" : "NO");
			return 0;
		}
	}

	return 0;
}
