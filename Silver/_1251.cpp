#include <iostream>
#include <string>
#include <algorithm>

using namespace std;

int main()
{
	string s, ans = "{}"; cin >> s;

	for (int i = 1; i < s.length() - 1; i++)
	{
		for (int j = i + 1;j < s.length(); j++)
		{
			string s1 = s.substr(0, i);
			reverse(s1.begin(), s1.end());
			
			string s2 = s.substr(i, j-i);
			reverse(s2.begin(), s2.end());
			
			string s3 = s.substr(j);
			reverse(s3.begin(), s3.end());

			string temp = s1 + s2 + s3;
			ans = min(ans, temp);
		}
	}

	cout << ans;
}
