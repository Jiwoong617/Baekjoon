#include <iostream>
#include <string>
#include <algorithm>

using namespace std;

int main()
{
	int n, cnt = 0; cin >> n;
	string* s = new string[n];
	for (int i = 0; i < n; i++)
		cin >> s[i];

	sort(s, s + n);
	for (int i = 0; i < n; i++)
	{
		for (int j = i + 1; j < n; j++)
		{
			if (s[j].find(s[i]) == 0)
			{
				cnt++;
				break;
			}
		}
	}

	cout << n - cnt;
	return 0;
}
