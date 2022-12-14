import React, { useState } from "react";
import "./LoginAttemptList.css";

const LoginAttempt = (props) => {
	console.log(props);
	const {attempts, filter} = props
	return attempts.filter(p => p.login.includes(filter)).map(attempt => <li key={attempt}>{attempt.login} - {attempt.date}</li>)
};

const LoginAttemptList = (props) => {
    const [filter, setFilter] = useState('')

	return (
		<div className="Attempt-List-Main">
	 		<p>Recent activity</p>
	  		<input type="input" placeholder="Filter..." onChange={(e) => { setFilter(e.target.value) }} />
			<ul className="Attempt-List">
				<LoginAttempt {...props} filter={filter} ></LoginAttempt>
			</ul>
		</div>
	)
};

export default LoginAttemptList;