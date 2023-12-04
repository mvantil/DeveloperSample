//#region Imports

import { useState } from 'react';

import "./LoginAttemptList.css";

//#endregion

//#region subcomponents

// using (props) is an antipattern, encouraging deep/unexpected prop drilling.
const LoginAttempt = ({ name }) => (
	<li className="Attempt">{name}</li>
);

//#endregion

// using (props) is an antipattern, encouraging deep/unexpected prop drilling.
const LoginAttemptList = ({ attempts }) => {

	//#region Hooks

	const [filterText, setFilterText] = useState('');

	//#endregion

	//#region Event Handlers

	const filterChanged = ({ target: { value } }) => {
		if (value !== filterText) {
			setFilterText(value);
		}
	};

	//#endregion

	return (
		<div className="Attempt-List-Main">
			<p>Recent activity</p>
			<input type="input" placeholder="Filter..." value={filterText} onChange={filterChanged} />
			<ul className="Attempt-List">
				{attempts.filter(({ name }) => name.includes(filterText)).map((attempt) => <LoginAttempt key={attempt.attempt} {...attempt} />)}
			</ul>
		</div>
	);
};

export default LoginAttemptList;
