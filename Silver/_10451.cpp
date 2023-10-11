#include <functional>
#include <iostream>
using namespace std;

int t, n;
int* num;
bool* visited;
void dfs(int n)
{
	visited[n] = true;
	if (!visited[num[n]])
		dfs(num[n]);
}

int main()
{
	ios::sync_with_stdio(0);
	cin.tie(0);
	cout.tie(0);

	cin >> t;
	while (t--)
	{
		cin >> n;
		num = new int[n + 1] {0};
		visited = new bool[n + 1] {false};
		for (int i = 1; i <= n; i++)
			cin >> num[i];

		int count = 0;
		for (int i = 1; i <= n; i++)
		{
			if (!visited[i])
			{
				dfs(i);
				count++;
			}
		}
		cout << count<< '\n';
	}
}
