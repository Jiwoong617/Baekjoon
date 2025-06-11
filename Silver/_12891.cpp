#include <iostream>
#include <string>
#include <unordered_map>

using namespace std;

int main()
{
	int n, m, a, c, g, t, ans = 0;
	string s;
	cin >> n >> m >> s >> a >> c >> g >> t;

	unordered_map<char, int> pw = { {'A', 0}, {'C', 0}, {'G', 0}, {'T', 0} };
	for (int i = 0; i < m; i++)
		pw[s[i]]++;

	if (pw['A'] >= a && pw['C'] >= c && pw['G'] >= g && pw['T'] >= t)
		ans++;

	for (int i = m; i < n; i++)
	{
		char dna1 = s[i - m], dna2 = s[i];
		pw[dna1]--; pw[dna2]++;

		if (pw['A'] >= a && pw['C'] >= c && pw['G'] >= g && pw['T'] >= t)
			ans++;
	}

	cout << ans;
	return 0;
}
