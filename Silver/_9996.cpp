#include <iostream>
#include <string>
#include <algorithm>

using namespace std;

int n;
string s, s1, s2;

int main()
{
	cin >> n >> s;
	s1 = s.substr(0, s.find('*'));
	s2 = s.substr(s.find('*') + 1);
	reverse(s2.begin(), s2.end());

	while (n--)
	{
		string t; cin >> t;

		if (s1.length() + s2.length() > t.length())
		{
			cout << "NE\n";
			continue;
		}

		if (t.find(s1) == 0)
		{
			reverse(t.begin(), t.end());
			if (t.find(s2) == 0) cout << "DA\n";
			else cout << "NE\n";
		}
		else cout << "NE\n";
	}

	return 0;
}
