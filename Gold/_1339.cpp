#include <iostream>
#include <string>
#include <cmath>
#include <algorithm>

using namespace std;

int main()
{
	int n, ans = 0; cin >> n;
	string s;
	int eng[26] = { 0, };

	while (n--)
	{
		cin >> s;
		for (int i =0; i<s.length(); i++)
			eng[s[i] - 'A'] += pow(10, s.length() - i - 1);
	}
	
	sort(eng, eng + 26, [](int a, int b)
		{
			return a > b;
		});

	for (int i = 9; i >= 0; i--)
		ans += (eng[9 - i] * i);

	cout << ans;
	return 0;
}
