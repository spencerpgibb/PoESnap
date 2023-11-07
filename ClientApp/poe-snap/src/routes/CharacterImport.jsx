import { Form, Link, redirect } from "react-router-dom";

import Modal from "../components/Modal";
import classes from "./CharacterImport.module.css";

function CharacterImport() {
  return (
    <Modal>
      <Form method="post" className={classes.form}>
        <p>
          <label htmlFor="accountName">Account Name</label>
          <input type="text" id="accountName" name="accountName" required />
        </p>
        <p>
          <label htmlFor="characterName">Character Name</label>
          <input type="text" id="characterName" name="characterName" required />
        </p>
        <p className={classes.actions}>
          <Link to=".." type="button">
            Cancel
          </Link>
          <button>Import</button>
        </p>
      </Form>
    </Modal>
  );
}

export default CharacterImport;

export async function action({ request }) {
  const formData = await request.formData();
  let postData = Object.fromEntries(formData);
 
  postData.accountName = encodeURI(postData.accountName);
  postData.characterName = encodeURI(postData.characterName);

  await fetch(`http://localhost:5270/api/character`, {
    method: "POST",
    body: JSON.stringify(postData),
    headers: {
      "Content-Type": "application/json",
    },
  });

  return redirect(`../view-character/${postData.characterName}`);
}
