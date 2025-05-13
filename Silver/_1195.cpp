#include <iostream>
#include <string>
#include <algorithm>

using namespace std;

int main()
{
	string s1, s2;
	cin >> s1 >> s2;
	if (s1.length() < s2.length())
		swap(s1, s2);

	int a = s1.length();
	int b = s2.length();
	int i, j, ans = a + b;

	bool flag;
	for (i = 0; i < a; i++)
	{
		flag = true;
		for (j = 0; j < b; j++)
		{
			if (i + j > a)
				break;

			if (s1[i + j] == '2' && s2[j] == '2')
			{
				flag = false;
				break;
			}
		}

		if (flag)
		{
			if (i + j > a)
				ans = min(i + b, ans);
			else
				ans = min(a, ans);
			break;
		}
	}

	for (i = 0; i < b; i++)
	{
		flag = true;
		for (j = 0; j < a; j++)
		{
			if (i + j > b)
				break;
			if (s2[i + j] == '2' && s1[j] == '2')
			{
				flag = false;
				break;
			}
		}

		if (flag)
			ans = min(i + a, ans);
	}

	cout << ans;
	return 0;
}
