#include <iostream>
#include <string>
#include <set>

using namespace std;

int main()
{
	int n; cin >> n;
	string* s = new string[n];
	for (int i = 0; i < n; i++)
		cin >> s[i];

	int i = 1;
	for (; i < s[0].length(); i++)
	{
		set<string> sets;
		for (int j = 0; j < n; j++)
		{
			if (!sets.insert(s[j].substr(s[j].length() - i, s[j].length())).second)
				break;
		}

		if (sets.size() == n)
			break;
	}

	cout << i;
	return 0;
}
