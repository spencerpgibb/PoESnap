import React from "react";
import ReactDOM from "react-dom/client";
import { RouterProvider, createBrowserRouter } from "react-router-dom";

import Character, { loader as characterLoader } from "./routes/Character";
import CharacterImport, {
  action as postCharacterAction,
} from "./routes/CharacterImport";
import RootLayout from "./routes/RootLayout";
import "./index.css";

const router = createBrowserRouter([
  {
    path: "/",
    element: <RootLayout />,
    children: [
      {
        path: "/import-character",
        element: <CharacterImport />,
        action: postCharacterAction,
      },
      {
        path: "/view-character/:characterName",
        element: <Character />,
        loader: characterLoader,
      },
    ],
  },
]);

ReactDOM.createRoot(document.getElementById("root")).render(
  <React.StrictMode>
    <RouterProvider router={router} />
  </React.StrictMode>
);
