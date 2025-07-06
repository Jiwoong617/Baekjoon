#include <iostream>
#include <string>
#include <algorithm>

using namespace std;

int main()
{
	int n, m; cin >> n >> m;
	string* s = new string[n];
	for (int i = 0; i < n; i++)
		cin >> s[i];

	int ans = 0;
	string dna = "";
	for (int i = 0; i < m; i++)
	{
		int cnt[4] = { 0, };
		for (int j = 0; j < n; j++)
		{
			switch (s[j][i])
			{
				case 'A':
					cnt[0]++;
					break;
				case 'C':
					cnt[1]++;
					break;
				case 'G':
					cnt[2]++;
					break;
				case 'T':
					cnt[3]++;
					break;
			}
		}

		int idx = max_element(cnt, cnt + 4) - cnt;
		ans += n - cnt[idx];
		if (idx == 0) dna += 'A';
		else if (idx == 1) dna += 'C';
		else if (idx == 2) dna += 'G';
		else if (idx == 3) dna += 'T';
	}

	cout << dna << '\n' << ans;
	return 0;
}
