#include <iostream>
#include <vector>
#include <algorithm>
#include <cmath>

using namespace std;

int main()
{
	int n, m, t, ans = 0; cin >> n >> m >> t;
	vector<int> horiz = { 0, m };
	vector<int> vert = { 0, n };
	for(int i = 0; i<t; i++)
	{
		int a, b; cin >> a >> b;
		if (a)
			vert.push_back(b);
		else
			horiz.push_back(b);
	}

	sort(horiz.begin(), horiz.end());
	sort(vert.begin(), vert.end());

	for (int i = 1; i < horiz.size(); i++)
		for (int j = 1; j < vert.size(); j++)
			ans = max(ans, (horiz[i] - horiz[i - 1]) * (vert[j] - vert[j - 1]));

	cout << ans;
	return 0;
}
