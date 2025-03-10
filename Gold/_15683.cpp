#include <algorithm>
#include <iostream>
#include <vector>
#include <climits>
using namespace std;

int n, m, a, ans = INT_MAX;
vector<int>* v;
struct cctv_info
{
	int x, y, type;
	cctv_info(int _x, int _y, int _type) : x(_x), y(_y), type(_type) {}
};
vector<cctv_info> cctv;

enum dir
{
	LEFT = 1,
	RIGHT = 2,
	UP = 3,
	DOWN = 4,
};

vector<pair<int, int>> cctv1(int x, int y, dir d)
{
	vector<pair<int, int>> vv;

	switch (d)
	{
	case LEFT:
		for (int i = y - 1; i >= 0; i--)
		{
			if (v[x][i] == 0)
			{
				v[x][i] = -1;
				vv.push_back(make_pair(x, i));
			}

			if (v[x][i] == 6) break;
		}
		break;
	case RIGHT:
		for (int i = y + 1; i < m; i++)
		{
			if (v[x][i] == 0)
			{
				v[x][i] = -1;
				vv.push_back(make_pair(x, i));
			}
			if (v[x][i] == 6) break;
		}
		break;
	case UP:
		for (int i = x - 1; i >= 0; i--)
		{
			if (v[i][y] == 0)
			{
				v[i][y] = -1;
				vv.push_back(make_pair(i, y));
			}

			if (v[i][y] == 6) break;
		}
		break;
	case DOWN:
		for (int i = x + 1; i < n; i++)
		{
			if (v[i][y] == 0)
			{
				v[i][y] = -1;
				vv.push_back(make_pair(i, y));
			}

			if (v[i][y] == 6) break;
		}
		break;
	}

	return vv;
}

vector<pair<int, int>> cctv2(int x, int y, dir d)
{
	vector<pair<int, int>> vv, vv2;

	switch (d)
	{
	case LEFT:
	case RIGHT:
		vv = cctv1(x, y, LEFT);
		vv2 = cctv1(x, y, RIGHT);
		break;
	case UP:
	case DOWN:
		vv = cctv1(x, y, UP);
		vv2 = cctv1(x, y, DOWN);
		break;
	}

	vv.insert(vv.end(), vv2.begin(), vv2.end());
	return vv;
}

vector<pair<int, int>> cctv3(int x, int y, dir d)
{
	vector<pair<int, int>> vv, vv2;

	switch (d)
	{
	case LEFT:
		vv = cctv1(x, y, LEFT);
		vv2 = cctv1(x, y, UP);
		break;
	case RIGHT:
		vv = cctv1(x, y, RIGHT);
		vv2 = cctv1(x, y, DOWN);
		break;
	case UP:
		vv = cctv1(x, y, UP);
		vv2 = cctv1(x, y, RIGHT);
		break;
	case DOWN:
		vv = cctv1(x, y, DOWN);
		vv2 = cctv1(x, y, LEFT);
		break;
	}

	vv.insert(vv.end(), vv2.begin(), vv2.end());
	return vv;
}

vector<pair<int, int>> cctv4(int x, int y, dir d)
{
	vector<pair<int, int>> vv, vv2, vv3;

	switch (d)
	{
	case LEFT:
		vv = cctv1(x, y, LEFT);
		vv2 = cctv1(x, y, UP);
		vv3 = cctv1(x, y, RIGHT);
		break;
	case RIGHT:
		vv = cctv1(x, y, RIGHT);
		vv2 = cctv1(x, y, DOWN);
		vv3 = cctv1(x, y, LEFT);
		break;
	case UP:
		vv = cctv1(x, y, UP);
		vv2 = cctv1(x, y, RIGHT);
		vv3 = cctv1(x, y, DOWN);
		break;
	case DOWN:
		vv = cctv1(x, y, DOWN);
		vv2 = cctv1(x, y, LEFT);
		vv3 = cctv1(x, y, UP);
		break;
	}

	vv.insert(vv.end(), vv2.begin(), vv2.end());
	vv.insert(vv.end(), vv3.begin(), vv3.end());
	return vv;
}

vector<pair<int, int>> cctv5(int x, int y)
{
	vector<pair<int, int>> vv, vv2, vv3, vv4;

	vv = cctv1(x, y, LEFT);
	vv2 = cctv1(x, y, RIGHT);
	vv3 = cctv1(x, y, UP);
	vv4 = cctv1(x, y, DOWN);

	vv.insert(vv.end(), vv2.begin(), vv2.end());
	vv.insert(vv.end(), vv3.begin(), vv3.end());
	vv.insert(vv.end(), vv4.begin(), vv4.end());
	return vv;
}

void rollback(vector<pair<int, int>> vv)
{
	for (auto aa : vv)
		v[aa.first][aa.second] = 0;
}

void Check()
{
	int temp = 0;
	for (int i = 0; i < n; i++)
		temp += count(v[i].begin(), v[i].end(), 0);
	
	//for (int i = 0; i < n; i++)
	//{
	//	for (int j = 0; j < m; j++)
	//		cout << v[i][j];
	//	cout << endl;
	//}
	//cout << endl;
	ans = min(ans, temp);
}

void dfs(int count)
{
	if (count == cctv.size())
	{
		Check();
		return;
	}

	cctv_info ci = cctv[count];
	vector<pair<int, int>> vv;
	for (int i = 1; i < 5; i++)
	{
		dir d = static_cast<dir>(i);
		switch (ci.type)
		{
		case 1:
			vv = cctv1(ci.x, ci.y, d);
			break;
		case 2:
			vv = cctv2(ci.x, ci.y, d);
			break;
		case 3:
			vv = cctv3(ci.x, ci.y, d);
			break;
		case 4:
			vv = cctv4(ci.x, ci.y, d);
			break;
		case 5:
			vv = cctv5(ci.x, ci.y);
			break;
		}
		dfs(count + 1);
		rollback(vv);
		vv.clear();
	}
}

int main()
{
	cin >> n >> m;
	v = new vector<int>[n];
	for (int i = 0; i < n; i++)
	{
		for (int j = 0; j < m; j++)
		{
			cin >> a;
			v[i].push_back(a);
			if (a > 0 && a < 6)
				cctv.push_back(cctv_info(i, j, a));
		}
	}

	dfs(0);

	cout << ans;
	return 0;
}
