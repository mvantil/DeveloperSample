import React, { useState } from "react";
import './App.css';
import LoginAttemptList from './LoginAttemptList';
import LoginForm from './LoginForm';

const App = () => {
  const [attempts, setAttempts] = useState(0);
  const [loginAttempts, setLoginAttempts] = useState([]);

  const handleLogin = (credentials) => {
    const attempt = attempts + 1;
    setAttempts(attempt);
    setLoginAttempts([...loginAttempts, { ...credentials, attempt }]);
  };

  return (
    <div className="App">
      <LoginForm handleLogin={handleLogin} />
      {attempts > 0 &&
        <LoginAttemptList attempts={loginAttempts.map(({ attempt, name }) => ({ attempt, name }))} />
      }
    </div>
  );
};

export default App;
