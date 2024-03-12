--Querry SQl Command

--Register
	/*
		--Add new account to table Account
		string sqlStr1 = string.Format("INSERT INTO Account(email, password, type) VALUES ('{0}', '{1}', '{2}')", txtEmail.Text, txtPassword.Text, type);

		--Count number of table
		string sqlStr3 = string.Format("select count(*) as C from {0}", type);

		SqlCommand cmd = new SqlCommand(sqlStr3, conn);
		int rowCount = (int)cmd.ExecuteScalar() + 1;
		--Create new ID
        string id = (type == "company") ? "C" + rowCount : "JS" + rowCount;

		--Add a new data to table
		string sqlStr2 = string.Format("INSERT INTO {0}(ID, email, name) VALUES ('{1}', '{2}', '{3}')", type, id, txtEmail.Text, txtPassword.Text);

		cmd = new SqlCommand(sqlStr1, conn);
		if (cmd.ExecuteNonQuery() > 0)
			MessageBox.Show("Sign Up success!!");
		cmd = new SqlCommand(sqlStr2, conn);
		cmd.ExecuteNonQuery();
	*/

--Login

	/*
		-- Get all account from Table Account
		string strSelect = string.Format("SELECT {0}.Email, Password, type, {0}.Name FROM Account A JOIN {0} ON A.Email = {0}.Email", type);

        SqlCommand cmdSelect = new SqlCommand(strSelect, conn);
		SqlDataReader reader = cmdSelect.ExecuteReader();
		bool ok = false;
		-- Read sequentially till get the true account or not!
		while (reader.Read())
		{
			if(type == reader["Type"].ToString().Trim())
			{
				if (txtEmail.Text == reader["Email"].ToString().Trim() && txtPassword.Text == reader["Password"].ToString().Trim())
				{
					MessageBox.Show("Sign in Success!!!");
					ok = true;
				}
			}
		}
	
	*/

--
		


