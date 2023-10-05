#include <algorithm>
#include <vector>
#include <set>
#include <iostream>
using namespace std;
int n, m;
set<vector<int>> s;
vector<int> temp;
int arr[8] = { 0 };
bool visited[8] = { false };

void BackT(int count, int start)
{
	if (count >= m)
	{
		s.insert(temp);
		return;
	}

	for (int i = start; i < n; i++)
	{
		if (visited[i]) continue;
		visited[i] = true;
		temp.push_back(arr[i]);
		BackT(count + 1, i + 1);
		visited[i] = false;
		temp.pop_back();
	}
}

int main()
{
	ios::sync_with_stdio(0);
	cin.tie(0);
	cout.tie(0);

	cin >> n >> m;
	for (int i = 0; i < n; i++)
		cin >> arr[i];
	sort(arr, arr + n);

	BackT(0, 0);
	for (auto a : s)
	{
		for (auto num : a)
			cout << num << ' ';
		cout << '\n';
	}
}
