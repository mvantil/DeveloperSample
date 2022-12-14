import React, { useState } from "react";
import './LoginForm.css';

const LoginForm = (props) => {
    const [data, setData] = useState({})

	const updateData = e => {
        setData({
            ...data,
            [e.target.id]: e.target.value
        })
    }

	const handleSubmit = (event) =>{
		event.preventDefault();
		props.onSubmit({
			login: data.name,
			password: data.password,
			date: (new Date()).toString(),
		});
	}

	return (
		<form className="form">
			<h1>Login</h1>
			<label htmlFor="name">Name</label>
			<input type="text" id="name" onChange={updateData}/>
			<label htmlFor="password">Password</label>
			<input type="password" id="password" onChange={updateData}/>
			<button type="submit" onClick={handleSubmit}>Continue</button>
		</form>
	)
}

export default LoginForm;