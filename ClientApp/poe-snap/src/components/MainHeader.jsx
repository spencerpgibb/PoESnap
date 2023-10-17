import { Link } from "react-router-dom";
import { IconContext } from "react-icons";
import { GrStorage } from "react-icons/gr";
import { AiOutlineImport } from "react-icons/ai";

import classes from "./MainHeader.module.css";

function MainHeader() {
  return (
    <header className={classes.header}>
      <h1 className={classes.logo}>
        <GrStorage />
        PoE Snap
      </h1>
      <p>
        <Link to="/import-character" className={classes.button}>
          <AiOutlineImport className={classes.importIcon} size={16} />
          Import Character
        </Link>
      </p>
    </header>
  );
}

export default MainHeader;
