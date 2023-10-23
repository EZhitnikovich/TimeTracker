import { FC, ReactElement } from "react";
import { BrowserRouter, Route, Routes } from "react-router-dom";
import "./App.css";
import userManager, { loadUser, signinRedirect } from "./auth/user-service";
import AuthProvider from "./auth/auth-provider";
import SignInOidc from "./auth/SigninOidc";
import SignOutOidc from "./auth/SignoutOidc";
import TagList from "./tags/TagList";

const App: FC<{}> = (): ReactElement => {
  loadUser();
  return (
    <div>
      <header>
        <button onClick={() => signinRedirect()}>Login</button>
        <AuthProvider userManager={userManager}>
          <BrowserRouter>
            <Routes>
              <Route path="/" element={<TagList />} />
              <Route path="/signout-oidc" element={<SignOutOidc />} />
              <Route path="/signin-oidc" element={<SignInOidc />} />
            </Routes>
          </BrowserRouter>
        </AuthProvider>
      </header>
    </div>
  );
};

export default App;
