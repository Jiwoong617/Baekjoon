#include <iostream>
#include <string>
#include <algorithm>

using namespace std;

int main()
{
	string s; cin >> s;

	for (int i = 0; i < s.length(); i++)
	{
		string ss = s.substr(i);
		reverse(ss.begin(), ss.end());

		if (s.substr(i) == ss)
		{
			cout << s.length() + i;
			return 0;
		}
	}
}
