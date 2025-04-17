#include <iostream>
#include <vector>
#include <algorithm>

using namespace std;

int n, d, k, c, ans = 0;
vector<int> susi;
vector<bool> susi_check;

int main()
{
	cin >> n >> d >> k >> c;
	susi = vector<int>(n);
	susi_check = vector<bool>(d + 1, 0);
	for (int i = 0; i < n; i++)
		cin >> susi[i];

	for (int i = 0; i< n; i++)
	{
		int dup_susi = 0;
		for (int j = i; j < i + k; j++)
		{
			if (susi_check[susi[j % n]])
				dup_susi++;
			else
				susi_check[susi[j % n]] = true;
		}

		if (susi_check[c])
			ans = max(ans, k - dup_susi);
		else
			ans = max(ans, k - dup_susi + 1);

		susi_check = vector<bool>(d + 1, 0);
	}

	cout << ans;

	return 0;
}
