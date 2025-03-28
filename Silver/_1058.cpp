#include <iostream>
#include <string>
#include <vector>
#include <unordered_set>
#include <algorithm>
using namespace std;


int n;
vector<string> f;
vector<unordered_set<int>> v;

void dfs(int start, int fr, int count)
{
	if (count == 3) return;

	v[start].insert(fr);
	for (int i = 0; i < n; i++)
	{
		if (f[fr][i] == 'Y')
			dfs(start, i, count+1);
	}
}

int main()
{
	cin >> n;
	string s;
	for (int i = 0; i < n; i++)
	{
		cin >> s;
		f.push_back(s);
		v.push_back(unordered_set<int>());
	}

	for (int i = 0; i < n; i++)
		dfs(i, i, 0);

	int max_size = std::max_element(v.begin(), v.end(),
		[](const auto& a, const auto& b) {
			return a.size() < b.size();
		})->size();

	cout << max_size - 1;

	return 0;
}
