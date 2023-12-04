import { useEffect, useState } from "react";
import './LoginForm.css';

const LoginForm = ({ handleLogin }) => {
	//#region Hooks

	const [loginName, setLoginName] = useState("");
	const [password, setPassword] = useState("");
	const [userCanSubmit, setUserCanSubmit] = useState(false);


	// this useEffect represents a rudimentary 'validation' 
	// and should also have an accompanying handler for browser auto-fill data
	// however as it was gold plating to begin with I tidyd up and stopped when I caught myself.
	useEffect(() => {
		const canSubmit = (loginName.length > 0 && password.length > 0)
			? true
			: false;
		if (userCanSubmit !== canSubmit) {
			setUserCanSubmit(canSubmit);
		}
	}, [loginName, password, userCanSubmit]);

	//#endregion

	//#region Event Handlers

	const handleNameChanged = (e) => {
		const { target: { value } } = e;

		if (value?.length > 0 && value !== loginName) {
			setLoginName(value);
			console.log(value);
		}
	};
	const handlePasswordChanged = (e) => {
		const { target: { value } } = e;

		if (value?.length > 0 && value !== password) {
			setPassword(value);
			console.log(value);
		}
	};
	const handleSubmit = (e) => {
		e.preventDefault();
		handleLogin({ name: loginName, password });
	};

	return (
		<form className="form" onSubmit={handleSubmit}>
			<h1>Login</h1>
			<label htmlFor="name">Name</label>
			<input type="text" value={loginName} onChange={handleNameChanged} />
			<label htmlFor="password">Password</label>
			<input type="password" value={password} onChange={handlePasswordChanged} />
			<button type="submit" disabled={!userCanSubmit}>Continue</button>
		</form>
	);
};

export default LoginForm;